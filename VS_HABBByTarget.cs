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
    public partial class VS_HABBByTarget : Form
    {
        System.Timers.Timer timer;

        VS_HABBFormData dataBB;
        List<TableLayoutPanel> hinhAnh;
        List<Label> idControls;
        List<Label> danControls;
        List<Label> scoreControls;
        List<Label> resultControls;

        VS_Main mf;

        public VS_HABBByTarget()
        {
            InitializeComponent();
        }

        public VS_HABBByTarget(VS_HABBFormData data)
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
            hinhAnh = new List<TableLayoutPanel>() { layoutHA_Sung1, layoutHA_Sung2, layoutHA_Sung3, layoutHA_Sung4, layoutHA_Sung5, layoutHA_Sung6, layoutHA_Sung7, layoutHA_Sung8, layoutHA_Sung9 };
            idControls = new List<Label>() { sung1_lblSung, sung2_lblSung, sung3_lblSung, sung4_lblSung, sung5_lblSung, sung6_lblSung, sung7_lblSung, sung8_lblSung, sung9_lblSung };
            danControls = new List<Label>() { sung1_lblBulletCount, sung2_lblBulletCount, sung3_lblBulletCount, sung4_lblBulletCount, sung5_lblBulletCount, sung6_lblBulletCount, sung7_lblBulletCount, sung8_lblBulletCount, sung9_lblBulletCount };
            scoreControls = new List<Label>() { sung1_lblScore, sung2_lblScore, sung3_lblScore, sung4_lblScore, sung5_lblScore, sung6_lblScore, sung7_lblScore, sung8_lblScore, sung9_lblScore };
            resultControls = new List<Label>() { sung1_lblResult, sung2_lblResult, sung3_lblResult, sung4_lblResult, sung5_lblResult, sung6_lblResult, sung7_lblResult, sung8_lblResult, sung9_lblResult };
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

            //Init bia images
            for (int i = 0; i < 9; i++)
            {
                //Init layout
                hinhAnh[i].ColumnCount = dataBB.fileBia.Count;
                for (int j = 0; j < dataBB.fileBia.Count; j++)
                {
                    hinhAnh[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
                    hinhAnh[i].ColumnStyles[j].Width = 100F / dataBB.fileBia.Count;
                }

                //Add images
                for (int j = 0; j < dataBB.thuTuSapXep.Count; j++)
                {
                    var thuTu = j + 1;
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
                        
                        hinhAnh[i].Controls.Add(picBox, j, 0);
                    }
                }
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            for (int gunId = 1; gunId < 10; gunId++)
            {
                var bulletCount = VS_NetworkManager.shootResult.Count(s => s.IdSung == gunId);
                if (bulletCount == 0) continue;

                //Draw bullet hit point or mark target as hit
                var scoreList = new List<string>();
                var scoreByTarget = new Dictionary<string, string>();//store data for crew shooting result
                bool ifAK3g = dataBB.idBaiBan == "S1_3g";//SPCECIAL CASE: AK-3g
                int scoreCount = ifAK3g ? 100 : 0;
                int hitCount = 0;//count total bullet hit target
                int missedCount = 0;//count total bullet missed
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
                            hitCount++;

                            int thuTuBia = dataBB.thuTuSapXep[indexBia];
                            var pic = (PictureBox)(hinhAnh[gunId - 1].GetControlFromPosition(thuTuBia - 1, 0));

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

                                if (ifAK3g)//SPCECIAL CASE: AK-3g
                                {
                                    scoreList.Add(hit.HitTarget.Replace("biaso", "").ToUpper());
                                    StoreResultByTarget(hit.HitTarget, "T", ref scoreByTarget);
                                }
                                else//normal cases
                                {
                                    scoreList.Add(hit.Score == 1 ? hit.HitTarget.Replace("biaso", "").ToUpper() : hit.Score.ToString());
                                    StoreResultByTarget(hit.HitTarget, hit.Score == 1 ? "T" : hit.Score.ToString(), ref scoreByTarget);
                                }
                            }
                            else//case draw bullet hit point
                            {
                                VS_Helper.DrawHitPointOnImage(pic, hit.WidthRatio, hit.HeightRatio, hit.HitTarget);
                                scoreList.Add(hit.Score.ToString());
                                StoreResultByTarget(hit.HitTarget, hit.Score.ToString(), ref scoreByTarget);
                            }

                            //Tinh diem
                            if (dataBB.scoreType == VS_BBScoreType.Marked)
                                scoreCount += hit.Score;
                            else
                            {
                                if (!hitTargetList.Contains(hit.HitTarget)) hitTargetList.Add(hit.HitTarget);
                                scoreCount = hitTargetList.Count;
                            }
                        }
                    }
                    //Truong hop truot muc tieu
                    else
                    {
                        missedCount++;
                        if (!hit.IsTypeHit && !ifAK3g)
                        {
                            scoreList.Add("0");
                            StoreResultByTarget(hit.HitTarget, "0", ref scoreByTarget);
                        }
                    }
                }


                //Calculate result
                //Check dk diem kha
                bool dkBiaDiemKhaOk = true;
                if (dataBB.biaDKDiemKha.Count > 0)
                {
                    foreach (var item in dataBB.biaDKDiemKha)
                    {
                        if (!VS_NetworkManager.shootResult.Any(s => s.HitTarget.ToLower() == item.ToLower()))//neu ko ban trung
                        {
                            dkBiaDiemKhaOk = false;
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
                scoreCount = scoreCount - tongDiemTru;

                //TODO: apply to VS_HABBByGun later
                //Check so dan trung muc tieu
                bool hitCountGioiOk = !dataBB.totalHitCheck || (dataBB.totalHitCheck && hitCount >= dataBB.totalHit_Gioi);
                bool hitCountKhaOk = !dataBB.totalHitCheck || (dataBB.totalHitCheck && hitCount >= dataBB.totalHit_Kha);
                bool hitCountDatOk = !dataBB.totalHitCheck || (dataBB.totalHitCheck && hitCount >= dataBB.totalHit_Dat);
                //Check diem gioi con phai thua dan
                bool bulletRemains_Gioi = !dataBB.bulletRemain_Gioi || (dataBB.bulletRemain_Gioi && dataBB.soLuongDan - hitLstByGunId.Count > 0);
                bool bulletRemains_Kha = !dataBB.bulletRemain_Kha || (dataBB.bulletRemain_Kha && dataBB.soLuongDan - hitLstByGunId.Count > 0);
                bool bulletRemains_Dat = !dataBB.bulletRemain_Dat || (dataBB.bulletRemain_Dat && dataBB.soLuongDan - hitLstByGunId.Count > 0);


                //Truong hop tinh diem theo thu tu vien dan trung muc tieu--B41-bai1
                bool firstHitGioiOk = true;
                bool firstHitKhaOk = true;
                bool firstHitDatOk = true;
                if (dataBB.firstHitCheck)
                {
                    int indexBulletHit = hitLstByGunId.FindIndex(s => !string.IsNullOrEmpty(s.HitTarget));
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
                if (scoreCount >= dataBB.diemGioi && hitCountGioiOk && firstHitGioiOk && bulletRemains_Gioi) tt = "Giỏi";
                else if (scoreCount >= dataBB.diemKha && dkBiaDiemKhaOk && hitCountKhaOk && firstHitKhaOk && bulletRemains_Kha) tt = "Khá";
                else if (scoreCount >= dataBB.diemKha && !dkBiaDiemKhaOk && hitCountDatOk && firstHitDatOk && bulletRemains_Dat) tt = "Đạt";
                else if (scoreCount >= dataBB.diemDat && hitCountDatOk && firstHitDatOk && bulletRemains_Dat) tt = "Đạt";

                if (banBiaKoDcPhep)
                {
                    scoreCount = 0;
                    tt = "Không đạt";
                }
                string rankStr = ifAK3g ? string.Empty : string.Format(". Xếp loại: {0}", tt);

                //Change ui
                var scoreStr = string.Join(" ", scoreList);
                if (dataBB.crewSetup[gunId - 1].Id != 0)
                    idControls[gunId - 1].Text = string.Format("Súng số {0} - {1}", gunId, dataBB.crewSetup[gunId - 1].Ten);
                else
                    idControls[gunId - 1].Text = string.Format("Súng số {0}", gunId);

                danControls[gunId - 1].Text = string.Format("Số đạn đã bắn: {0}. Trượt: {1}", bulletCount, missedCount);
                scoreControls[gunId - 1].Text = dataBB.scoreType == VS_BBScoreType.Hit || ifAK3g
                    ? string.Format("Trúng bia: {0}", scoreStr)
                    : string.Format("Điểm: {0}", scoreStr);
                
                if (dataBB.scoreType == VS_BBScoreType.Marked)
                    resultControls[gunId - 1].Text = string.Format("Thành tích: {0} điểm{1}", scoreCount, rankStr);
                else
                    resultControls[gunId - 1].Text = string.Format("Thành tích: Trúng {0} bia{1}", scoreCount, rankStr);

                idControls[gunId - 1].ForeColor = Color.Red;
                danControls[gunId - 1].ForeColor = Color.Red;
                scoreControls[gunId - 1].ForeColor = Color.Red;
                resultControls[gunId - 1].ForeColor = Color.Red;

                //Save crew shooting result 
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

                    var tmpScore = string.Join(" | ", scoreByTarget.Select(x => string.Format("{0} : {1}", x.Key, x.Value)));
                    userResult.ThanhTich = tmpScore;
                    userResult.TongDiem = scoreCount;
                    userResult.XepLoai = ifAK3g ? string.Empty : tt;
                }
            }
        }

        private void VS_HABBByTarget_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                timer.Stop();
        }

        void StoreResultByTarget(string target, string score, ref Dictionary<string, string> rs)
        {
            target = target.Replace("biaso", "").Trim();

            if (rs.ContainsKey(target))
                rs[target] = rs[target] + " " + score;
            else
                rs.Add(target, score);
        }
    }
}
