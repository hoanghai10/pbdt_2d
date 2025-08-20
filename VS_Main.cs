using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PBDT_2D.Manager;

namespace PBDT_2D.Forms
{
    public partial class VS_Main : Form
    {
        VS_NetworkManager netManager;

        //Flag controls
        bool isShooting;
        bool isEditExCondition;

        //Crew setup
        public string savedCrewSetup;
        public List<VS_User> crCrewSetupEx;
        public int crTeacherId;

        //Crew shooting data
        public VS_KipBan crCrewInfo;
        public List<VS_KetQua> crCrewShootingResult;

        VS_Baiban crShootingEx;
        VS_Baiban crSelectedEx;
        int crSelectedGridRowIndex;

        public VS_Main()
        {
            InitializeComponent();

            LoadData();
            ConnectTo3D();
        }

        #region Load data
        void LoadData()
        {
            LoadCboLoaiSung();
        }

        void LoadCboLoaiSung()
        {
            var lst = VS_DBManager.LoadDanhSachSung();

            leftTop_cboLoaiSung.DataSource = lst;
            leftTop_cboLoaiSung.DisplayMember = "Name";
            leftTop_cboLoaiSung.ValueMember = "Id";
        }

        void LoadGrdDSBB()
        {
            if (leftTop_cboLoaiSung.SelectedItem != null)
            {
                var idSung = ((VS_LoaiSung)leftTop_cboLoaiSung.SelectedItem).Id;
                var lst = VS_DBManager.LoadDSBBTheoLoaiSung(idSung);

                leftMid_grdDSBB.AutoGenerateColumns = false;
                leftMid_grdDSBB.DataSource = lst;
            }
        }

        void LoadThongTinBB()
        {
            if (crSelectedEx != null)
            {
                var picBB = VS_Helper.LoadEmbeddedImage(crSelectedEx.Id);
                if (picBB == null)
                {
                    midTop_picHABB.Image = midTop_picHABB.ErrorImage;
                    midTop_picHABB.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    midTop_picHABB.Image = picBB;
                    midTop_picHABB.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        void LoadDieuKienBB()
        {
            rightTop_layoutDieuKienBB.Controls.Clear();

            if (crSelectedEx == null) return;

            //DK tung bia
            var lstBia = crSelectedEx.DanhSachBia.Split('|').ToList();
            var lstThoiGian = crSelectedEx.ThoiGianAnHien.Split('|').ToList();

            int count = Math.Max(lstBia.Count, lstThoiGian.Count);
            for (int i = 0; i < count; i++)
            {
                //var dkBia = new VS_DieuKienBia();

                var bia = i < lstBia.Count ? lstBia[i] : string.Empty;
                var tg = i < lstThoiGian.Count ? lstThoiGian[i] : string.Empty;
                //dkBia.InitData(bia, tg);

                //rightTop_layoutDieuKienBB.Controls.Add(dkBia);
            }

            //DK bai ban
            //var dkBB = new VS_DieuKienBB();
            //khong can mo dkBB.InitData(crSelectedEx.SoLuongDan, crSelectedEx.DiemGioi, crSelectedEx.DiemKha, crSelectedEx.DiemDat);
            //dkBB.InitData(crSelectedEx);
            //rightTop_layoutDieuKienBB.Controls.Add(dkBB);
        }

        void GetSelectedBB()
        {
            if (leftMid_grdDSBB.SelectedRows.Count == 1)
            {
                var result = new VS_Baiban();

                result.Id = leftMid_grdDSBB.SelectedRows[0].Cells["Id"].Value.ToString();
                result.TenBB = leftMid_grdDSBB.SelectedRows[0].Cells["TenBB"].Value.ToString();
                result.IdSung = leftMid_grdDSBB.SelectedRows[0].Cells["IdSung"].Value.ToString();
                result.SoLuongDan = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["SoLuongDan"].Value.ToString());
                result.DanhSachBia = leftMid_grdDSBB.SelectedRows[0].Cells["DanhSachBia"].Value.ToString();
                result.ThuTuSapXep2D = leftMid_grdDSBB.SelectedRows[0].Cells["ThuTuSapXep2D"].Value.ToString();
                result.ThoiGianAnHien = leftMid_grdDSBB.SelectedRows[0].Cells["ThoiGianAnHien"].Value.ToString();
                result.DiemGioi = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["DiemGioi"].Value.ToString());
                result.DiemKha = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["DiemKha"].Value.ToString());
                result.DiemDat = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["DiemDat"].Value.ToString());
                result.ScoreType = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["ScoreType"].Value.ToString());
                result.DisplayType = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["DisplayType"].Value.ToString());
                result.BiaDKKha = leftMid_grdDSBB.SelectedRows[0].Cells["BiaDKKha"].Value.ToString();
                result.BiaKoTrungTruDiem = leftMid_grdDSBB.SelectedRows[0].Cells["BiaKoTrungTruDiem"].Value.ToString();
                result.BiaKoDuocBan = leftMid_grdDSBB.SelectedRows[0].Cells["BiaKoDuocBan"].Value.ToString();

                result.TotalHitCheck = bool.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["TotalHitCheck"].Value.ToString());
                result.TotalHit_Gioi = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["TotalHit_Gioi"].Value.ToString());
                result.TotalHit_Kha = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["TotalHit_Kha"].Value.ToString());
                result.TotalHit_Dat = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["TotalHit_Dat"].Value.ToString());

                result.FirstHitCheck = bool.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["FirstHitCheck"].Value.ToString());
                result.FirstHit_Gioi = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["FirstHit_Gioi"].Value.ToString());
                result.FirstHit_Kha = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["FirstHit_Kha"].Value.ToString());
                result.FirstHit_Dat = int.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["FirstHit_Dat"].Value.ToString());

                result.BulletRemainsCheck = bool.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["BulletRemainsCheck"].Value.ToString());
                result.BulletRemain_Gioi = bool.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["BulletRemain_Gioi"].Value.ToString());
                result.BulletRemain_Kha = bool.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["BulletRemain_Kha"].Value.ToString());
                result.BulletRemain_Dat = bool.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["BulletRemain_Dat"].Value.ToString());

                result.DrawHitPoint = bool.Parse(leftMid_grdDSBB.SelectedRows[0].Cells["DrawHitPoint"].Value.ToString());

                crSelectedEx = result;
                crSelectedGridRowIndex = leftMid_grdDSBB.SelectedRows[0].Index;
            }
            else
            {
                crSelectedEx = null;
                crSelectedGridRowIndex = -1;
            }

            LoadSceneByGunOrBB();
        }
        #endregion

        #region Events
        private void leftTop_cboLoaiSung_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrdDSBB();
        }

        private void leftMid_grdDSBB_SelectionChanged(object sender, EventArgs e)
        {
            GetSelectedBB();
            LoadThongTinBB();
            LoadDieuKienBB();
            UpdateUI();
        }

        private void midBot_btnStart_Click(object sender, EventArgs e)
        {
            PreviewOrStartBB(VS_CommandType.SetupCrew);
        }

        private void midBot_btnStop_Click(object sender, EventArgs e)
        {
            StopBB();
        }

        private void midBot_btnViewHABeBan_Click(object sender, EventArgs e)
        {
            ShowHABB();
        }

        private void rightBot_btnEditDKBB_Click(object sender, EventArgs e)
        {
            if (!isEditExCondition)//Enable controls
            {
                isEditExCondition = true;
            }
            else//Try save data
            {
                if (WrapDKBBData(out VS_Baiban newData))
                {
                    //update grid && db data
                    if (!UpdateDKBBInGrid(newData)) return;
                    if (!VS_DBManager.UpdateDKBaiBan(newData)) return;

                    isEditExCondition = false;
                    MessageBox.Show("Cập nhật thông tin bài bắn thành công");

                    //update selected ex data
                    GetSelectedBB();
                }
            }

            UpdateUI();
        }

        private void rightBot_btnCancelDKBB_Click(object sender, EventArgs e)
        {
            //Reset data
            //int count = rightTop_layoutDieuKienBB.Controls.Count;
            //for (int i = 0; i < count - 1; i++)
            //    ((VS_DieuKienBia)rightTop_layoutDieuKienBB.Controls[i]).ResetData();

            //((VS_DieuKienBB)rightTop_layoutDieuKienBB.Controls[count - 1]).ResetData();

            //isEditExCondition = false;
            //UpdateUI();
        }

        private void leftBot_btnUser_Click(object sender, EventArgs e)
        {
            var userForm = new VS_DanhSachPhuTrach();
            userForm.ShowDialog();
        }

        private void leftBot_btnCrewSetup_Click(object sender, EventArgs e)
        {
            //var crewForm = new VS_CrewSetup();
            //crewForm.ShowDialog();
        }

        private void leftBot_btnSearch_Click(object sender, EventArgs e)
        {
            //var searchForm = new VS_Search();
            //searchForm.ShowDialog();
        }
        #endregion

        #region Methods
        public void SetConnectStatus(bool isConnected)
        {
            if (leftBot_lblConnect.InvokeRequired)
            {
                leftBot_lblConnect.Invoke(new MethodInvoker(delegate ()
                {
                    leftBot_lblConnect.Text = isConnected ? "Đã kết nối" : "Chưa kết nối";
                    leftBot_lblConnect.ForeColor = isConnected ? Color.Green : Color.Red;
                }));
            }
            else
            {
                leftBot_lblConnect.Text = isConnected ? "Đã kết nối" : "Chưa kết nối";
                leftBot_lblConnect.ForeColor = isConnected ? Color.Green : Color.Red;
            }
        }

        void ConnectTo3D()
        {
            netManager = new VS_NetworkManager();
            netManager.ConnectTo3D(this);
        }

        public bool PreviewOrStartBB(VS_CommandType command)
        {
            if (command != VS_CommandType.Preview &&
                command != VS_CommandType.Start &&
                command != VS_CommandType.SetupCrew) return false;

            if (crSelectedEx != null)
            {
                var dataTo3D = new VS_DataTo3D();
                dataTo3D.Command = (int)command;
                dataTo3D.IdBaiBan = crSelectedEx.Id;
                dataTo3D.SoLuongDan = crSelectedEx.SoLuongDan;
                dataTo3D.DanhSachBia = crSelectedEx.DanhSachBia;
                dataTo3D.ThoiGianAnHien = crSelectedEx.ThoiGianAnHien;
                dataTo3D.DiemGioi = crSelectedEx.DiemGioi;
                dataTo3D.DiemKha = crSelectedEx.DiemKha;
                dataTo3D.DiemDat = crSelectedEx.DiemDat;
                dataTo3D.CalculateHitPoint = crSelectedEx.DrawHitPoint;

                //Other conditions
                dataTo3D.TotalHitCheck = crSelectedEx.TotalHitCheck;
                dataTo3D.TotalHit_Gioi = crSelectedEx.TotalHit_Gioi;
                dataTo3D.TotalHit_Kha = crSelectedEx.TotalHit_Kha;
                dataTo3D.TotalHit_Dat = crSelectedEx.TotalHit_Dat;

                dataTo3D.FirstHitCheck = crSelectedEx.FirstHitCheck;
                dataTo3D.FirstHit_Gioi = crSelectedEx.FirstHit_Gioi;
                dataTo3D.FirstHit_Kha = crSelectedEx.FirstHit_Kha;
                dataTo3D.FirstHit_Dat = crSelectedEx.FirstHit_Dat;

                dataTo3D.BulletRemainsCheck = crSelectedEx.BulletRemainsCheck;
                dataTo3D.BulletRemain_Gioi = crSelectedEx.BulletRemain_Gioi;
                dataTo3D.BulletRemain_Kha = crSelectedEx.BulletRemain_Kha;
                dataTo3D.BulletRemain_Dat = crSelectedEx.BulletRemain_Dat;

                //TODO: send them cac dieu kien BiaDKKha/BiaKoTrungTruDiem/BiaKoDuocBan

                //switch 3d command from normal to ban tong hop
                if (dataTo3D.IdBaiBan.Contains("S99_"))
                {
                    dataTo3D.Command += 100;
                }
                //end switch command

                if (command == VS_CommandType.SetupCrew)
                {
                    var msgResult = netManager.SendCommandTo3D(dataTo3D, out bool connected);
                    if (!string.IsNullOrEmpty(msgResult))
                    {
                        MessageBox.Show(msgResult);
                        SetConnectStatus(connected);

                        return false;
                    }

                    //var crewForm = new VS_CrewSetup(
                    //    string.Format("{0} {1}", ((VS_LoaiSung)leftTop_cboLoaiSung.SelectedItem).Name, crSelectedEx.TenBB),
                    //    savedCrewSetup);

                    //crewForm.ShowDialog();

                    return true;
                }
                else
                {
                    var msgResult = netManager.SendCommandTo3D(dataTo3D, out bool connected);
                    if (!string.IsNullOrEmpty(msgResult))
                    {
                        MessageBox.Show(msgResult);
                        SetConnectStatus(connected);

                        return false;
                    }
                    else
                    {
                        if (command == VS_CommandType.Start)
                        {
                            isShooting = true;
                            crShootingEx = crSelectedEx;
                            VS_NetworkManager.shootResult = new List<VS_DataFrom3D>();
                            UpdateUI();

                            crCrewInfo = new VS_KipBan
                            {
                                IdBaiBan = crShootingEx.Id,
                                TenBaiBanFull = string.Format("{0} {1}", ((VS_LoaiSung)leftTop_cboLoaiSung.SelectedItem).Name, crShootingEx.TenBB),
                                ThoiGianBatDau = DateTime.Now,
                                ThoiGianKetThuc = DateTime.Now,//assign later when stop exercise
                                IdNguoiDung = crTeacherId
                            };
                            crCrewShootingResult = new List<VS_KetQua>();

                            bool isTongHop = crShootingEx.Id.Contains("S99_");
                            if (!isTongHop)
                                ShowHABB();
                        }

                        return true;
                    }
                }
            }

            return false;
        }

        public void EndPreviewBB()
        {
            if (isShooting) return;

            var dataTo3D = new VS_DataTo3D();
            dataTo3D.Command = (int)VS_CommandType.CancelSetupCrew;

            var msgResult = netManager.SendCommandTo3D(dataTo3D, out bool connected);
            if (!string.IsNullOrEmpty(msgResult))
            {
                MessageBox.Show(msgResult);
                SetConnectStatus(connected);
            }
        }

        void StopBB()
        {
            var dataTo3D = new VS_DataTo3D();
            dataTo3D.Command = (int)VS_CommandType.Stop;

            //switch 3d command from normal to ban tong hop
            if (crShootingEx.Id.Contains("S99_"))
            {
                dataTo3D.Command += 100;
            }
            //end switch command

            var msgResult = netManager.SendCommandTo3D(dataTo3D, out bool connected);
            if (!string.IsNullOrEmpty(msgResult))
            {
                MessageBox.Show(msgResult);
                SetConnectStatus(connected);
            }
            else
            {
                isShooting = false;
                crShootingEx = null;
                UpdateUI();
                VS_NetworkManager.shootResult = new List<VS_DataFrom3D>();

                crCrewInfo.ThoiGianKetThuc = DateTime.Now;
                if (crCrewShootingResult.Count > 0)//if have any shooting user
                    VS_DBManager.SaveCrewResult(crCrewInfo, crCrewShootingResult);
            }
        }

        void LoadSceneByGunOrBB()
        {
            if (crSelectedEx == null) return;

            var dataTo3D = new VS_DataTo3D();
            dataTo3D.Command = (int)VS_CommandType.LoadScene;
            dataTo3D.IdBaiBan = crSelectedEx.Id;

            var msgResult = netManager.SendCommandTo3D(dataTo3D, out bool connected);
        }

        void ShowHABB()
        {
            string typeName = crShootingEx.DisplayType == (int)VS_BBDisplayType.ByTarget ? "TBA2D.Forms.VS_HABBByTarget" : "TBA2D.Forms.VS_HABBByGun";
            //Assembly entryAssembly = Assembly.GetEntryAssembly();
            Type type = Type.GetType(typeName);

            var data = new VS_HABBFormData(
                    string.Format("{0} {1}", ((VS_LoaiSung)leftTop_cboLoaiSung.SelectedItem).Name, crShootingEx.TenBB),
                    crSelectedEx,
                    crCrewSetupEx);

            if (data.hasError)
            {
                MessageBox.Show("Lỗi hiện hình ảnh bài bắn!");
            }
            else
            {
                object obj = Activator.CreateInstance(type, new object[] { data });

                Form form = (Form)obj;
                form.ShowDialog();
                form.Dispose();
            }
        }

        void UpdateUI()
        {
            midBot_btnStart.Enabled = !isShooting && leftMid_grdDSBB.SelectedRows.Count == 1;
            midBot_btnStop.Enabled = isShooting;
            midBot_btnViewHABeBan.Enabled = isShooting;


            //UI edit DKBB
            if (isEditExCondition)
            {
                //info section
                foreach (Control c in rightTop_layoutDieuKienBB.Controls)
                    c.Enabled = true;

                //dkbb btns
                rightBot_btnEditDKBB.Text = "Cập nhật";
                rightBot_btnCancelDKBB.Enabled = true;

                //other sections
                leftTop_cboLoaiSung.Enabled = false;
                leftMid_gbDSBB.Enabled = false;
                midBot_gbMainFunctions.Enabled = false;
            }
            else
            {
                //info section
                foreach (Control c in rightTop_layoutDieuKienBB.Controls)
                    c.Enabled = false;

                //dkbb btns
                rightBot_btnEditDKBB.Text = "Sửa điều kiện";
                rightBot_btnCancelDKBB.Enabled = false;

                //other sections
                leftTop_cboLoaiSung.Enabled = true;
                leftMid_gbDSBB.Enabled = true;
                midBot_gbMainFunctions.Enabled = true;
            }
        }

        bool WrapDKBBData(out VS_Baiban data)
        {
            data = new VS_Baiban();

            int count = rightTop_layoutDieuKienBB.Controls.Count;

            var msg = string.Empty;
            //lay data dk bia
            var lstTgAnHien = new List<string>();
            //for (int i = 0; i < count - 1; i++)
            //{
            //    var dkBia = (VS_DieuKienBia)rightTop_layoutDieuKienBB.Controls[i];
            //    msg = dkBia.GetData(out string tgAnHien);

            //    if (string.IsNullOrEmpty(msg))
            //        lstTgAnHien.Add(tgAnHien);
            //    else
            //    {
            //        MessageBox.Show(msg);
            //        return false;
            //    }
            //}
            data.ThoiGianAnHien = string.Join("|", lstTgAnHien);

            //lay data dk tinh diem
            //var dkBB = (VS_DieuKienBB)rightTop_layoutDieuKienBB.Controls[count - 1];
            //msg = dkBB.GetData(ref data);
            //if (!string.IsNullOrEmpty(msg))
            //{
            //    MessageBox.Show(msg);
            //    return false;
            //}

            data.Id = crSelectedEx.Id;
            data.IdSung = crSelectedEx.IdSung;

            return true;
        }

        bool UpdateDKBBInGrid(VS_Baiban data)
        {
            try
            {
                if (crSelectedGridRowIndex != -1 && crSelectedGridRowIndex < leftMid_grdDSBB.RowCount)
                {
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["ThoiGianAnHien"].Value = data.ThoiGianAnHien;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["SoLuongDan"].Value = data.SoLuongDan;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["DiemGioi"].Value = data.DiemGioi;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["DiemKha"].Value = data.DiemKha;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["DiemDat"].Value = data.DiemDat;

                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["TotalHitCheck"].Value = data.TotalHitCheck;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["TotalHit_Gioi"].Value = data.TotalHit_Gioi;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["TotalHit_Kha"].Value = data.TotalHit_Kha;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["TotalHit_Dat"].Value = data.TotalHit_Dat;

                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["FirstHitCheck"].Value = data.FirstHitCheck;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["FirstHit_Gioi"].Value = data.FirstHit_Gioi;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["FirstHit_Kha"].Value = data.FirstHit_Kha;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["FirstHit_Dat"].Value = data.FirstHit_Dat;

                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["BulletRemainsCheck"].Value = data.BulletRemainsCheck;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["BulletRemain_Gioi"].Value = data.BulletRemain_Gioi;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["BulletRemain_Kha"].Value = data.BulletRemain_Kha;
                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["BulletRemain_Dat"].Value = data.BulletRemain_Dat;

                    leftMid_grdDSBB.Rows[crSelectedGridRowIndex].Cells["DrawHitPoint"].Value = data.DrawHitPoint;

                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công");
                return false;
            }
        }

        #endregion


    }
}
