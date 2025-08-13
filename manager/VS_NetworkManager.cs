using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TBDT_2D.Forms;

namespace TBDT_2D.Manager
{
    public class VS_NetworkManager
    {
        TcpListener mTCPListener;
        List<VS_ClientNode> mlClientSocks;
        VS_Main frmMain;
        VS_DataFrom3D dataReceived;

        public static List<VS_DataFrom3D> shootResult;//Luu tru cac phat dan trong phien ban

        public string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }
            catch (Exception)
            {                
                MessageBox.Show("Không lấy được địa chỉ IP");
            }

            return string.Empty;
        }

        public void ConnectTo3D(VS_Main form)
        {
            frmMain = form;
            int port = 8001;
            if (IPAddress.TryParse(GetLocalIPAddress(), out IPAddress localaddr))
            {
                this.mTCPListener = new TcpListener(localaddr, port);
                this.mTCPListener.Start();
                this.mTCPListener.BeginAcceptTcpClient(new AsyncCallback(this.onCompleteAcceptTcpClient), this.mTCPListener);
            }
            else
                MessageBox.Show("Không lấy được địa chỉ IP");
        }

        public string SendCommandTo3D(VS_DataTo3D data, out bool connectedTo3D)
        {
            try
            {
                VS_ClientNode clientNode = null;
                if (mlClientSocks != null)
                {
                    clientNode = mlClientSocks[0];
                    clientNode.Tx = new byte[512];
                }

                lock (mlClientSocks)
                {
                    if (clientNode != null && clientNode.tclient != null && clientNode.tclient.Client.Connected)
                    {
                        StructureToByteArray(data, ref clientNode.Tx);
                        clientNode.tclient.GetStream().BeginWrite(clientNode.Tx, 0, clientNode.Tx.Length, new AsyncCallback(onCompleteWriteToClientStream), clientNode.tclient);                        
                    }
                }
                connectedTo3D = true;
            }
            catch (Exception)
            {
                connectedTo3D = false;
                return "Chưa kết nối với máy 3D";
            }

            return string.Empty;
        }

        void StructureToByteArray(object obj, ref byte[] byteArray)
        {
            int num = Marshal.SizeOf(obj);
            IntPtr intPtr = Marshal.AllocHGlobal(num);
            Marshal.StructureToPtr(obj, intPtr, true);
            Marshal.Copy(intPtr, byteArray, 0, num);
            Marshal.FreeHGlobal(intPtr);
        }

        void ByteArrayToStructure(byte[] bytesArray, ref VS_DataFrom3D obj)
        {
            int num = Marshal.SizeOf(obj);
            byte[] array = new byte[num];
            Array.Copy(bytesArray, array, num);
            IntPtr intPtr = Marshal.AllocHGlobal(num);
            Marshal.Copy(array, 0, intPtr, num);
            obj = (VS_DataFrom3D)Marshal.PtrToStructure(intPtr, typeof(VS_DataFrom3D));
            Marshal.FreeHGlobal(intPtr);
        }

        void onCompleteAcceptTcpClient(IAsyncResult iar)
        {
            this.mlClientSocks = new List<VS_ClientNode>(2);
            TcpListener tcpListener = (TcpListener)iar.AsyncState;
            TcpClient tcpClient = null;
            VS_ClientNode clientNode = null;

            try
            {
                tcpClient = tcpListener.EndAcceptTcpClient(iar);

                //this.frmMain.SetConnectStatus(true);

                tcpListener.BeginAcceptTcpClient(new AsyncCallback(this.onCompleteAcceptTcpClient), tcpListener);
                lock (this.mlClientSocks)
                {
                    this.mlClientSocks.Add(clientNode = new VS_ClientNode(tcpClient, new byte[512], new byte[512], tcpClient.Client.RemoteEndPoint.ToString()));
                }
                try
                {
                    tcpClient.GetStream().BeginRead(clientNode.Rx, 0, clientNode.Rx.Length, new AsyncCallback(this.onCompleteReadFromTCPClientStream), tcpClient);
                }
                catch
                {
                }
            }
            catch (Exception)
            {
                tcpListener.Stop();
                //this.frmMain.SetConnectStatus(false);
                MessageBox.Show("Chưa có kết nối đến máy 3D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void onCompleteReadFromTCPClientStream(IAsyncResult iar)
        {
            VS_ClientNode clientNode = null;
            try
            {
                lock (mlClientSocks)
                {
                    TcpClient tcpc = (TcpClient)iar.AsyncState;
                    clientNode = this.mlClientSocks.Find((VS_ClientNode x) => x.strId == tcpc.Client.RemoteEndPoint.ToString());
                    int num = tcpc.GetStream().EndRead(iar);
                    if (num == 0)
                    {
                        mlClientSocks.Remove(clientNode);
                        //frmMain.SetConnectStatus(false);
                    }
                    else
                    {
                        ByteArrayToStructure(clientNode.Rx, ref dataReceived);

                        //Add shoot result
                        if (!dataReceived.IsQuitApplication)
                            shootResult.Add(dataReceived);  
                        else
                        {
                            mlClientSocks.Remove(clientNode);
                            //frmMain.SetConnectStatus(false);
                        }

                        tcpc.GetStream().BeginRead(clientNode.Rx, 0, clientNode.Rx.Length, new AsyncCallback(this.onCompleteReadFromTCPClientStream), tcpc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                lock (this.mlClientSocks)
                {
                    //this.frmMain.SetConnectStatus(false);
                    this.mlClientSocks.Remove(clientNode);
                }
            }
        }

        void onCompleteWriteToClientStream(IAsyncResult iar)
        {
            try
            {
                TcpClient tcpClient = (TcpClient)iar.AsyncState;
                tcpClient.GetStream().EndWrite(iar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
