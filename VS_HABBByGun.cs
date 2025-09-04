using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PBDT_2D.Manager;

namespace PBDT_2D.Forms
{
    public partial class VS_HABBByGun : Form
    {
        System.Timers.Timer timer;

        VS_HABBFormData dataBB;
        List<Label> idControls;
        List<Label> danControls;
        List<Label> scoreControls;

        VS_Main mf;

        public VS_HABBByGun()
        {
            InitializeComponent();
        }

        public VS_HABBByGun(VS_HABBFormData data)
        {
            dataBB = data;

            InitializeComponent();
            InitializeForm();

            timer = new System.Timers.Timer();
            timer.SynchronizingObject = this;
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        void InitializeForm()
        {
            this.Text = string.Format("HÌNH ẢNH BỆ BẮN - {0}", dataBB.tenBaiBan);
            mf = (VS_Main)Application.OpenForms["VS_Main"];

            //Init list
            idControls = new List<Label>() { lblSung1, lblSung2, lblSung3, lblSung4, lblSung5, lblSung6, lblSung7, lblSung8, lblSung9 };
            danControls = new List<Label>() { lblBulletCount1, lblBulletCount2, lblBulletCount3, lblBulletCount4, lblBulletCount5, lblBulletCount6, lblBulletCount7, lblBulletCount8, lblBulletCount9 };
            scoreControls = new List<Label>() { lblScore1, lblScore2, lblScore3, lblScore4, lblScore5, lblScore6, lblScore7, lblScore8, lblScore9 };
            if (dataBB.scoreType == VS_BBScoreType.Hit)
                foreach (var item in scoreControls)
                    item.Text = "Trúng bia:";

            //Apply crew user name to gun labels
            for (int i = 0; i < dataBB.crewSetup.Count; i++)
            {
                if (dataBB.crewSetup[i].Id != 0)
                {
                    idControls[i].Text = string.Format("Súng số {0} - {1}", i + 1, dataBB.crewSetup[i].Ten);
                }
            }

            //Init layout images
            layoutHA.ColumnCount = dataBB.fileBia.Count;
            for (int i = 0; i < dataBB.fileBia.Count; i++)
            {
                layoutHA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
                layoutHA.ColumnStyles[i].Width = 100F / dataBB.fileBia.Count;                
            }

            //Add images
            for (int i = 0; i < dataBB.thuTuSapXep.Count; i++)
            {
                var thuTu = i + 1;
                var index = dataBB.thuTuSapXep.IndexOf(thuTu);
                if (index != -1)
                {
                    var biaHienThi = dataBB.fileBia[index];
                    var biaHienThiError = dataBB.fileBiaError[index];
                    var img = VS_Helper.LoadEmbeddedImage(biaHienThi);
                    var imgError = VS_Helper.LoadEmbeddedImage(biaHienThiError);

                    var picBox = new PictureBox();
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.Dock = DockStyle.Fill;

                    picBox.Image = img;
                    picBox.InitialImage = img;
                    picBox.ErrorImage = imgError;

                    layoutHA.Controls.Add(picBox, i, 0);
                }
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            int totalScore = 0;
            for (int gunId = 1; gunId < 10; gunId++)
            {
                var bulletCount = VS_NetworkManager.shootResult.Count(s => s.IdSung == gunId);
                if (bulletCount == 0) continue;

                //Draw bullet hit point or mark target as hit
                var scoreList = new List<string>();
                int scoreByGun = 0;
                int missedCount = 0;
                var hitTargetList = new List<string>();
                var hitLstByGunId = VS_NetworkManager.shootResult.Where(s => s.IdSung == gunId).ToList();
                foreach (var hit in hitLstByGunId)
                {
                    //Truong hop trung muc tieu
                    if (!string.IsNullOrEmpty(hit.HitTarget))
                    {
                        int indexBia = dataBB.target3D.IndexOf(hit.HitTarget.ToLower());
                        if (indexBia != -1)//trung bia muc tieu
                        {
                            int thuTuBia = dataBB.thuTuSapXep[indexBia];
                            var pic = (PictureBox)(layoutHA.GetControlFromPosition(thuTuBia - 1, 0));

                            if (hit.IsTypeHit)//case mark target as hit
                            {
                                if (hit.TypeHit_DisplayHitPoint)//draw hit point
                                {
                                    VS_Helper.DrawHitPointOnImage(pic, hit.WidthRatio, hit.HeightRatio, hit.HitTarget);
                                }
                                else//draw red crosses
                                {
                                    pic.Image = pic.ErrorImage;
                                }
                                
                                scoreList.Add(hit.Score == 1 ? hit.HitTarget.Replace("biaso", "").ToUpper() : hit.Score.ToString());
                            }
                            else//case draw bullet hit point
                            {
                                VS_Helper.DrawHitPointOnImage(pic, hit.WidthRatio, hit.HeightRatio, hit.HitTarget);
                                scoreList.Add(hit.Score.ToString());
                            }

                            //Tinh diem
                            if (dataBB.scoreType == VS_BBScoreType.Marked)
                                scoreByGun += hit.Score;
                            else
                            {
                                if (!hitTargetList.Contains(hit.HitTarget)) hitTargetList.Add(hit.HitTarget);
                                scoreByGun = hitTargetList.Count;
                            }
                        }
                    }
                    //Truong hop truot muc tieu
                    else
                    {
                        missedCount++;

                        //scoreList.Add(hit.IsTypeHit ? "Trượt" : "0");
                        if (!hit.IsTypeHit)
                            scoreList.Add("0");
                    }
                }

                totalScore += scoreByGun;

                //Change ui
                var scoreStr = string.Join(" ", scoreList);
                danControls[gunId - 1].Text = string.Format("Số đạn đã bắn: {0}. Trượt: {1}", bulletCount, missedCount);
                scoreControls[gunId - 1].Text = dataBB.scoreType == VS_BBScoreType.Marked
                    ? string.Format("Điểm: {0}", scoreStr)
                    : string.Format("Trúng bia: {0}", scoreStr);

                idControls[gunId - 1].ForeColor = Color.Red;
                danControls[gunId - 1].ForeColor = Color.Red;
                scoreControls[gunId - 1].ForeColor = Color.Red;
                lblTotalResult.ForeColor = Color.Red;

                //Save crew shooting result BY GUN
                if (dataBB.crewSetup[gunId - 1].Id != 0)
                {
                    var userResult = mf.crCrewShootingResult.FirstOrDefault(r => r.IdNguoiDung == dataBB.crewSetup[gunId - 1].Id);
                    if (userResult == null)
                    {
                        userResult = new VS_KetQua
                        {
                            IdNguoiDung = dataBB.crewSetup[gunId - 1].Id,
                            IdSung = gunId
                        };
                        mf.crCrewShootingResult.Add(userResult);
                    }
                    
                    userResult.ThanhTich = scoreStr;
                }
            }


            //Calculate result
            //Check dk diem kha
            bool dkDiemKhaOK = true;
            if (dataBB.biaDKDiemKha.Count > 0)
            {
                foreach (var item in dataBB.biaDKDiemKha)
                {
                    if (!VS_NetworkManager.shootResult.Any(s => s.HitTarget.ToLower() == item.ToLower()))//neu ko ban trung
                    {
                        dkDiemKhaOK = false;
                        break;
                    }
                }
            }
            //Check bia ko dc ban
            bool banBiaKoDcPhep = false;
            if (dataBB.biaKoDuocBan.Count > 0)
            {
                foreach (var item in dataBB.biaKoDuocBan)
                {
                    if (VS_NetworkManager.shootResult.Any(s => s.HitTarget.ToLower() == item.ToLower()))//neu ban trung
                    {
                        banBiaKoDcPhep = true;
                        break;
                    }
                }
            }
            //Check bia tru diem
            int tongDiemTru = 0;
            if (dataBB.biaKoTrungTruDiem.Count > 0)
            {
                foreach (var item in dataBB.biaKoTrungTruDiem)
                {
                    if (!VS_NetworkManager.shootResult.Any(s => s.HitTarget.ToLower() == item.Key.ToLower()))//neu ko ban trung
                    {
                        tongDiemTru += item.Value;
                    }
                }
            }
            totalScore = totalScore - tongDiemTru;

            //TODO:add more conditions
            //Truong hop tinh diem theo thu tu loat dan trung muc tieu-MTTK AK 3
            bool firstHitGioiOk = true;
            bool firstHitKhaOk = true;
            bool firstHitDatOk = true;
            if (dataBB.firstHitCheck)
            {
                //Tinh loat ban trung
                int indexBulletHit = -1;
                //Lay thu tu vien ban trung cua tat ca cac sung
                var indexHitTmp = VS_NetworkManager.shootResult.FindIndex(s => !string.IsNullOrWhiteSpace(s.HitTarget));
                if (indexHitTmp != -1)
                {
                    //Lay danh sach dan da ban cua tat ca cac sung cho toi khi trung muc tieu
                    var lstTmp = VS_NetworkManager.shootResult.Skip(0).Take(indexHitTmp + 1);

                    var maxHitPerGun = lstTmp.GroupBy(x => x.IdSung).Max(x => x.Count());
                    indexBulletHit = maxHitPerGun - 1;
                }
                else
                    indexBulletHit = -1;
                
                if (indexBulletHit != -1)
                {
                    firstHitGioiOk = (indexBulletHit + 1) <= dataBB.firstHit_Gioi;
                    firstHitKhaOk = (indexBulletHit + 1) <= dataBB.firstHit_Kha;
                    firstHitDatOk = (indexBulletHit + 1) <= dataBB.firstHit_Dat;
                }
                else
                {
                    firstHitGioiOk = false;
                    firstHitKhaOk = false;
                    firstHitDatOk = false;
                }
            }

            //Calculte total result
            string tt = "Không đạt";
            if (totalScore >= dataBB.diemGioi && firstHitGioiOk) tt = "Giỏi";
            else if (totalScore >= dataBB.diemKha && dkDiemKhaOK && firstHitKhaOk) tt = "Khá";
            else if (totalScore >= dataBB.diemKha && !dkDiemKhaOK && firstHitDatOk) tt = "Đạt";
            else if (totalScore >= dataBB.diemDat && firstHitDatOk) tt = "Đạt";

            if (banBiaKoDcPhep) tt = "Không đạt";

            if (dataBB.scoreType == VS_BBScoreType.Marked)
                lblTotalResult.Text = string.Format("Thành tích: {0} điểm. Xếp loại: {1}", totalScore, tt);
            else
                lblTotalResult.Text = string.Format("Thành tích: Trúng {0} bia. Xếp loại: {1}", totalScore, tt);

            //Save crew shooting result TOTAL
            foreach (var rs in mf.crCrewShootingResult)
            {
                rs.TongDiem = totalScore;
                rs.XepLoai = tt;
            }
        }

        private void VS_HABBByGun_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                timer.Stop();
        }
    }
}
