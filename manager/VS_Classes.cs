using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace PBDT_2D.Manager
{
    //COMMON

    public class VS_LoaiSung
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }

    public enum VS_BBScoreType
    {
        Marked = 1,
        Hit = 2
    }

    public enum VS_BBDisplayType
    {
        ByTarget = 1,
        ByGun = 2
    }

    public enum VS_DBCommandType
    {
        Insert = 1,
        Update = 2,
        Delete = 3
    }

    public class VS_Baiban
    {
        public string Id { get; set; }
        public string TenBB { get; set; }
        public string IdSung { get; set; }
        public int SoLuongDan { get; set; }
        public string DanhSachBia { get; set; }
        public string ThuTuSapXep2D { get; set; }
        public string ThoiGianAnHien { get; set; }
        public int DiemGioi { get; set; }
        public int DiemKha { get; set; }
        public int DiemDat { get; set; }
        public int ScoreType { get; set; }
        public int DisplayType { get; set; }

        //Additional conditions
        public string BiaDKKha { get; set; }
        public string BiaKoTrungTruDiem { get; set; }
        public string BiaKoDuocBan { get; set; }

        public bool TotalHitCheck { get; set; }
        public int TotalHit_Gioi { get; set; }
        public int TotalHit_Kha { get; set; }
        public int TotalHit_Dat { get; set; }

        public bool FirstHitCheck { get; set; }
        public int FirstHit_Gioi { get; set; }
        public int FirstHit_Kha { get; set; }
        public int FirstHit_Dat { get; set; }

        public bool BulletRemainsCheck { get; set; }
        public bool BulletRemain_Gioi { get; set; }
        public bool BulletRemain_Kha { get; set; }
        public bool BulletRemain_Dat { get; set; }

        public bool DrawHitPoint { get; set; }
    }

    public class VS_HABBFormData
    {
        public string idBaiBan;
        public string tenBaiBan;
        public VS_BBScoreType scoreType;
        public string danhSachBia;
        public int soLuongDan;

        public List<string> fileBia;
        public List<string> fileBiaError;
        public List<int> thuTuSapXep;
        public List<string> target3D;
        public List<string> biaDKDiemKha;
        public List<string> biaKoDuocBan;
        public Dictionary<string, int> biaKoTrungTruDiem;        

        public int diemGioi;
        public int diemKha;
        public int diemDat;

        public bool totalHitCheck;
        public int totalHit_Gioi;
        public int totalHit_Kha;
        public int totalHit_Dat;

        public bool firstHitCheck;
        public int firstHit_Gioi;
        public int firstHit_Kha;
        public int firstHit_Dat;

        public bool bulletRemainsCheck;
        public bool bulletRemain_Gioi;
        public bool bulletRemain_Kha;
        public bool bulletRemain_Dat;

        public bool drawHitPoint;

        public bool hasError;

        public List<VS_User> crewSetup;
        
        public VS_HABBFormData(string tenBB, VS_Baiban dataBaiBan, List<VS_User> dataCrewSetup)
        {
            try
            {
                crewSetup = dataCrewSetup;

                idBaiBan = dataBaiBan.Id;
                tenBaiBan = tenBB;
                scoreType = (VS_BBScoreType)dataBaiBan.ScoreType;
                danhSachBia = dataBaiBan.DanhSachBia;
                soLuongDan = dataBaiBan.SoLuongDan;

                diemGioi = dataBaiBan.DiemGioi;
                diemKha = dataBaiBan.DiemKha;
                diemDat = dataBaiBan.DiemDat;

                totalHitCheck = dataBaiBan.TotalHitCheck;
                totalHit_Gioi = dataBaiBan.TotalHit_Gioi;
                totalHit_Kha = dataBaiBan.TotalHit_Kha;
                totalHit_Dat = dataBaiBan.TotalHit_Dat;

                firstHitCheck = dataBaiBan.FirstHitCheck;
                firstHit_Gioi = dataBaiBan.FirstHit_Gioi;
                firstHit_Kha = dataBaiBan.FirstHit_Kha;
                firstHit_Dat = dataBaiBan.FirstHit_Dat;

                bulletRemainsCheck = dataBaiBan.BulletRemainsCheck;
                bulletRemain_Gioi = dataBaiBan.BulletRemain_Gioi;
                bulletRemain_Kha = dataBaiBan.BulletRemain_Kha;
                bulletRemain_Dat = dataBaiBan.BulletRemain_Dat;

                drawHitPoint = dataBaiBan.DrawHitPoint;


                fileBia = new List<string>();
                fileBiaError = new List<string>();
                thuTuSapXep = new List<int>();
                target3D = new List<string>();
                biaDKDiemKha = new List<string>();
                biaKoDuocBan = new List<string>();
                biaKoTrungTruDiem = new Dictionary<string, int>();


                if (!string.IsNullOrEmpty(danhSachBia))
                {
                    var lst = danhSachBia.Split('|').ToList();

                    //Ten file anh bia
                    fileBia = lst.Select(x => "bia_" + x + "").ToList();
                    fileBiaError = lst.Select(x => "bia_" + x + "_hit").ToList();

                    //Thu tu sap xep va ten bia 3D
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (string.IsNullOrEmpty(dataBaiBan.ThuTuSapXep2D)) thuTuSapXep.Add(i + 1);//thu tu hien thi bia nhu thu tu danh sach bia

                        int count = lst.Count(b => b == lst[i]);

                        if (count == 1) target3D.Add(string.Format("biaso{0}", lst[i]).ToLower());
                        else
                        {
                            int index = 1;
                            for (int j = 0; j < i; j++)
                                if (lst[j] == lst[i])
                                    index++;

                            target3D.Add(string.Format("biaso{0}{1}", lst[i], index).ToLower());
                        }

                    }

                    if (!string.IsNullOrEmpty(dataBaiBan.ThuTuSapXep2D))//thu tu hien thi tuy chinh
                        thuTuSapXep = dataBaiBan.ThuTuSapXep2D.Split(',').Select(x => int.Parse(x)).ToList();

                    //Dieu kien them
                    var lstDK = dataBaiBan.BiaDKKha.Split('|').Where(x => !string.IsNullOrEmpty(x)).ToList();
                    var lstKoBan = dataBaiBan.BiaKoDuocBan.Split('|').Where(x => !string.IsNullOrEmpty(x)).ToList();
                    foreach (var index in lstDK) biaDKDiemKha.Add(target3D[int.Parse(index) - 1]);
                    foreach (var index in lstKoBan) biaKoDuocBan.Add(target3D[int.Parse(index) - 1]);

                    var lstTruDiem = dataBaiBan.BiaKoTrungTruDiem.Split('|').Where(x => !string.IsNullOrEmpty(x)).ToList();
                    foreach (var str in lstTruDiem)
                    {
                        var arr = str.Split('-').ToArray();
                        var index = int.Parse(arr[0]);
                        var diemTru = int.Parse(arr[1]);

                        biaKoTrungTruDiem.Add(target3D[index - 1], diemTru);
                    }
                }                
            }
            catch (Exception)
            {
                hasError = true;
            }
        }
    }

    public class VS_QuanHam
    {
        public int Id { get; set; }
        public string QuanHam { get; set; }
    }

    [Serializable]
    public class VS_User
    {
        public int Id { get; set; }
        public int ThuTu { get; set; }
        public string Ten { get; set; }
        public int QuanHamId { get; set; }
        public string QuanHam { get; set; }
        public string ChucVu { get; set; }
        public string DonVi { get; set; }
        public string GhiChu { get; set; }
        public int? NamSinh { get; set; }


        public VS_User()
        {
            Id = 0;
            ThuTu = 0;
            Ten = string.Empty;
            QuanHamId = 0;
            QuanHam = string.Empty;
            ChucVu = string.Empty;
            DonVi = string.Empty;
            GhiChu = string.Empty;
            NamSinh = null;
        }
    }
    [Serializable]
    public class VS_GiaoVu
    {
        public int Id { get; set; }
        public int ThuTu { get; set; }
        public int QuanHamId { get; set; }
        public string HoTen { get; set; }
        public int? NamSinh { get; set; }
        public string QuanHam { get; set; }

        public VS_GiaoVu()
        {
            Id = 0;
            ThuTu = 0;
            QuanHamId = 0;
            HoTen = string.Empty;
            NamSinh = null;
            QuanHam = string.Empty;
        }
    }

    public class VS_BindingGun
    {
        public int GunId { get; set; }
    }

    public class VS_KipBan
    {
        public int Id { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string IdBaiBan { get; set; }
        public string TenBaiBanFull { get; set; }
        public int IdNguoiDung { get; set; }
        public bool IsSelected { get; set; }
        
    }

    public class VS_KetQua
    {
        public int Id { get; set; }
        public int IdKipBan { get; set; }
        public int IdNguoiDung { get; set; }
        public int IdSung { get; set; }
        public string ThanhTich { get; set; }
        public int TongDiem { get; set; }
        public string XepLoai { get; set; }
    }

    public class VS_DBTransactionQueryItem
    {
        public VS_DBCommandType Type { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, string> Data { get; set; }
        public string WhereClause { get; set; }
    }

    public class VS_SearchConditions
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string IdSung { get; set; }
        public string IdBaiBan { get; set; }
        public string IdKBRange { get; set; }
        public int IdTeacher { get; set; }
    }

    public class VS_SearchResult
    {
        public int IdKetQua { get; set; }
        public string IdBaiBan { get; set; }
        public string TenBaiBanFull { get; set; }
        public DateTime TGBatDau { get; set; }
        public DateTime TGKetThuc { get; set; }
        public int ND_Id { get; set; }
        public string ND_Ten { get; set; }
        public string ND_QuanHam { get; set; }
        public string ND_ChucVu { get; set; }
        public string ND_DonVi { get; set; }
        public string ND_GhiChu { get; set; }
        public int ND_IdSungBan { get; set; }
        public string ND_ThanhTich { get; set; }
        public int ND_TongDiem { get; set; }
        public string ND_XepLoai { get; set; }
        public bool IsSelected { get; set; }
    }

    [Serializable]
    public class VS_PrintHeaderSetup
    {
        public string HeaderId { get; set; }
        public string HeaderDisplay { get; set; }
        public int HeaderWidth { get; set; }
        public bool IsSelected { get; set; }
    }

    //For preview before print
    public class VS_PrintPreviewSettings
    {
        //Page
        public Rectangle Page_Bounds { get; set; }
        public Margins Page_Margins { get; set; }
        public int Page_x0 { get; set; }
        public int Page_y0 { get; set; }
        public int Page_w { get; set; }
        public int Page_h { get; set; }
        public bool Page_Lanscape { get; set; }

        //Header
        public bool Header_Draw { get; set; }
        public string Header_Text { get; set; }
        public Font Header_Font { get; set; }
        public StringFormat Header_Format { get; set; }
        public RectangleF Header_Bounds { get; set; }
        public PointF Header_LineStartPoint { get; set; }//will be calculate when have text and font
        public PointF Header_LineEndPoint { get; set; }//will be calculate when have text and font

        //Title
        public bool Title_Draw { get; set; }
        public string Title_Text { get; set; }
        public Font Title_Font { get; set; }
        public StringFormat Title_Format { get; set; }
        public RectangleF Title_Bounds { get; set; }//will be calculate when have text and font

        //Content first sentences
        public bool FirstSentences_Draw { get; set; }
        public string FirstSentences_Text { get; set; }
        public Font FirstSentences_Font { get; set; }
        public StringFormat FirstSentences_Format { get; set; }
        public RectangleF FirstSentences_Bounds { get; set; }//will be calculate when have text and font

        //Content        
        public Font Content_HeaderFont { get; set; }
        public Font Content_Font { get; set; }
        public StringFormat Content_GridFormat { get; set; }
        public VS_PrintDataRow Content_HeaderRow { get; set; }
        public List<VS_PrintDataRow> Content_DataRows { get; set; }

        //Footer
        public bool Footer_Draw { get; set; }
        public Font Footer_Font { get; set; }
        public string Footer_TextPattern { get; set; }
        public StringFormat Footer_Format { get; set; }
        public RectangleF Footer_Bounds { get; set; }
        public PointF Footer_LineStartPoint { get; set; }//will be calculate when have text and font
        public PointF Footer_LineEndPoint { get; set; }//will be calculate when have text and font
    }

    public class VS_PrintDataRow
    {
        public List<VS_PrintDataCell> Cells;
        public int PageNumber;

        public VS_PrintDataRow()
        {
            Cells = new List<VS_PrintDataCell>();
        }
    }

    public class VS_PrintDataCell
    {
        public string GridColumnId { get; set; }
        public string Text { get; set; }
        public RectangleF Bounds { get; set; }
    }

    //For save settings to file
    [Serializable]
    public class VS_PrintSettings
    {
        public bool Page_Lanscape { get; set; }

        //Header
        public bool Header_Draw { get; set; }
        public string Header_Text { get; set; }
        public Font Header_Font { get; set; }        
        public StringAlignment Header_Format { get; set; }        

        //Title
        public bool Title_Draw { get; set; }
        public string Title_Text { get; set; }
        public Font Title_Font { get; set; }
        public StringAlignment Title_Format { get; set; }        

        //Content first sentences
        public bool FirstSentences_Draw { get; set; }
        public string FirstSentences_Text { get; set; }
        public Font FirstSentences_Font { get; set; }
        public StringAlignment FirstSentences_Format { get; set; }

        //Content
        public List<VS_PrintHeaderSetup> Content_GridHeaderSetup { get; set; }
        public Font Content_HeaderFont { get; set; }
        public Font Content_Font { get; set; }
        public StringAlignment Content_GridFormat { get; set; }

        //Footer
        public bool Footer_Draw { get; set; }
        public Font Footer_Font { get; set; }
        public int Footer_TextPatternIndex { get; set; }
        public StringAlignment Footer_Format { get; set; }        
    }

    //NETWORK

    public class VS_ClientNode : IEquatable<string>
    {
        public TcpClient tclient;
        public byte[] Tx;
        public byte[] Rx;
        public string strId;

        public VS_ClientNode()
        {
            this.Tx = new byte[512];
            this.Rx = new byte[512];
            this.strId = string.Empty;
            this.tclient = new TcpClient();
        }

        public VS_ClientNode(TcpClient _tclient, byte[] _tx, byte[] _rx, string _str)
        {
            this.tclient = _tclient;
            this.Tx = _tx;
            this.Rx = _rx;
            this.strId = _str;
        }

        public VS_ClientNode(TcpClient _tclient)
        {
            this.tclient = _tclient;
            this.Tx = new byte[512];
            this.Rx = new byte[512];
            this.strId = string.Empty;
        }

        bool IEquatable<string>.Equals(string other)
        {
            return !string.IsNullOrEmpty(other) && this.tclient != null && this.strId.Equals(other);
        }

        public new string ToString()
        {
            return this.strId;
        }
    }
    
    public enum VS_CommandType
    {
        None = 0,
        //Nomal
        Preview = 1,
        Start = 2,
        Stop = 3,
        SetupCrew = 4,
        CancelSetupCrew = 5,
        //Ban tong hop: normal + 100
        BanTongHop_Preview = 101,
        BanTongHop_Start = 102,
        BanTongHop_Stop = 103,
        BanTongHop_SetupCrew = 104,
        //others
        LoadScene = 900,
        Quit = 999
    }

    public struct VS_DataTo3D
    {
        public int Command;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IdBaiBan;
                
        public int SoLuongDan;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DanhSachBia;
        
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string ThoiGianAnHien;
                
        public int DiemGioi;                
        public int DiemKha;                
        public int DiemDat;
        public bool CalculateHitPoint;

        public bool TotalHitCheck;
        public int TotalHit_Gioi;
        public int TotalHit_Kha;
        public int TotalHit_Dat;

        public bool FirstHitCheck;
        public int FirstHit_Gioi;
        public int FirstHit_Kha;
        public int FirstHit_Dat;

        public bool BulletRemainsCheck;
        public bool BulletRemain_Gioi;
        public bool BulletRemain_Kha;
        public bool BulletRemain_Dat;
    }

    public struct VS_DataFrom3D
    {
        public bool IsQuitApplication;

        public int IdSung;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string HitTarget;
        
        public int Score;

        public bool IsTypeHit;

        public bool TypeHit_DisplayHitPoint;

        public float WidthRatio;

        public float HeightRatio;
    }
}
