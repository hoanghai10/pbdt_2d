using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PBDT_2D.Manager;

namespace TBA2D.Forms.UserControls
{
    public partial class VS_DieuKienBB : UserControl
    {
        VS_Baiban originalData;

        public VS_DieuKienBB()
        {
            InitializeComponent();
        }

        public void InitData(VS_Baiban dataBB)
        {
            originalData = dataBB;

            tbSoDan.Text = dataBB.SoLuongDan.ToString();
            tbDiemGioi.Text = dataBB.DiemGioi.ToString();
            tbDiemKha.Text = dataBB.DiemKha.ToString();
            tbDiemDat.Text = dataBB.DiemDat.ToString();

            cbDrawHitPoint.Checked = dataBB.DrawHitPoint;

            //Count hit bullet
            cbCountHit.Checked = dataBB.TotalHitCheck;
            tbCountHit_Gioi.Enabled = dataBB.TotalHitCheck;
            tbCountHit_Kha.Enabled = dataBB.TotalHitCheck;
            tbCountHit_Dat.Enabled = dataBB.TotalHitCheck;
            tbCountHit_Gioi.Text = dataBB.TotalHit_Gioi.ToString();
            tbCountHit_Kha.Text = dataBB.TotalHit_Kha.ToString();
            tbCountHit_Dat.Text = dataBB.TotalHit_Dat.ToString();

            //Count first hit
            cbCountFirstHit.Checked = dataBB.FirstHitCheck;
            tbFirstHit_Gioi.Enabled = dataBB.FirstHitCheck;
            tbFirstHit_Kha.Enabled = dataBB.FirstHitCheck;
            tbFirstHit_Dat.Enabled = dataBB.FirstHitCheck;
            tbFirstHit_Gioi.Text = dataBB.FirstHit_Gioi.ToString();
            tbFirstHit_Kha.Text = dataBB.FirstHit_Kha.ToString();
            tbFirstHit_Dat.Text = dataBB.FirstHit_Dat.ToString();

            //Count bullet remains
            cbBulletRemains.Checked = dataBB.BulletRemainsCheck;
            cbBulletRemain_Gioi.Enabled = dataBB.BulletRemainsCheck;
            cbBulletRemain_Kha.Enabled = dataBB.BulletRemainsCheck;
            cbBulletRemain_Dat.Enabled = dataBB.BulletRemainsCheck;
            cbBulletRemain_Gioi.Checked = dataBB.BulletRemain_Gioi;
            cbBulletRemain_Kha.Checked = dataBB.BulletRemain_Kha;
            cbBulletRemain_Dat.Checked = dataBB.BulletRemain_Dat;

        }

        //public string GetData(ref VS_Baiban dataBBEdited)
        //{
        //    try
        //    {
        //        //check empty
        //        bool inputOK_soDan = !string.IsNullOrWhiteSpace(tbSoDan.Text);
        //        bool inputOK_diem = !string.IsNullOrWhiteSpace(tbDiemGioi.Text) 
        //                            && !string.IsNullOrWhiteSpace(tbDiemKha.Text) 
        //                            && !string.IsNullOrWhiteSpace(tbDiemDat.Text);
        //        bool inputOK_totalHit = !cbCountHit.Checked || (cbCountHit.Checked
        //                                                        && !string.IsNullOrWhiteSpace(tbCountHit_Gioi.Text)
        //                                                        && !string.IsNullOrWhiteSpace(tbCountHit_Kha.Text)
        //                                                        && !string.IsNullOrWhiteSpace(tbCountHit_Dat.Text));
        //        bool inputOK_firstHit = !cbCountFirstHit.Checked || (cbCountFirstHit.Checked
        //                                                            && !string.IsNullOrWhiteSpace(tbFirstHit_Gioi.Text)
        //                                                            && !string.IsNullOrWhiteSpace(tbFirstHit_Kha.Text)
        //                                                            && !string.IsNullOrWhiteSpace(tbFirstHit_Dat.Text));

        //        if (!inputOK_soDan || !inputOK_diem || !inputOK_totalHit || !inputOK_firstHit)
        //            return "Chưa nhập dữ liệu";

        //        //check number
        //        int numberCheck = 0;
        //        if (!int.TryParse(tbSoDan.Text, out numberCheck) || numberCheck <= 0) return "SỐ ĐẠN phải là số nguyên > 0";

        //        if (!int.TryParse(tbDiemGioi.Text, out numberCheck) || numberCheck < 0) return "ĐIỂM GIỎI phải là số nguyên >= 0";
        //        if (!int.TryParse(tbDiemKha.Text, out numberCheck) || numberCheck < 0) return "ĐIỂM KHÁ phải là số nguyên >= 0";
        //        if (!int.TryParse(tbDiemDat.Text, out numberCheck) || numberCheck < 0) return "ĐIỂM ĐẠT phải là số nguyên >= 0";

        //        if (cbCountHit.Checked && 
        //            (!int.TryParse(tbCountHit_Gioi.Text, out numberCheck) || numberCheck <= 0)) return "SỐ VIÊN trúng mục tiêu điểm GIỎI phải là số nguyên > 0";
        //        if (cbCountHit.Checked &&
        //            (!int.TryParse(tbCountHit_Kha.Text, out numberCheck) || numberCheck <= 0)) return "SỐ VIÊN trúng mục tiêu điểm KHÁ phải là số nguyên > 0";
        //        if (cbCountHit.Checked &&
        //            (!int.TryParse(tbCountHit_Dat.Text, out numberCheck) || numberCheck <= 0)) return "SỐ VIÊN trúng mục tiêu điểm ĐẠT phải là số nguyên > 0";

        //        if (cbCountFirstHit.Checked &&
        //            (!int.TryParse(tbFirstHit_Gioi.Text, out numberCheck) || numberCheck <= 0)) return "THỨ TỰ viên trúng đầu tiên điểm GIỎI phải là số nguyên > 0";
        //        if (cbCountFirstHit.Checked &&
        //            (!int.TryParse(tbFirstHit_Kha.Text, out numberCheck) || numberCheck <= 0)) return "THỨ TỰ viên trúng đầu tiên điểm KHÁ phải là số nguyên > 0";
        //        if (cbCountFirstHit.Checked &&
        //            (!int.TryParse(tbFirstHit_Dat.Text, out numberCheck) || numberCheck <= 0)) return "THỨ TỰ viên trúng đầu tiên điểm ĐẠT phải là số nguyên > 0";

        //        //pass data
        //        dataBBEdited.SoLuongDan = int.Parse(tbSoDan.Text);
        //        dataBBEdited.DrawHitPoint = cbDrawHitPoint.Checked;

        //        dataBBEdited.DiemGioi = int.Parse(tbDiemGioi.Text);
        //        dataBBEdited.DiemKha = int.Parse(tbDiemKha.Text);
        //        dataBBEdited.DiemDat = int.Parse(tbDiemDat.Text);

        //        dataBBEdited.TotalHitCheck = cbCountHit.Checked;
        //        dataBBEdited.TotalHit_Gioi = int.Parse(tbCountHit_Gioi.Text);
        //        dataBBEdited.TotalHit_Kha = int.Parse(tbCountHit_Kha.Text);
        //        dataBBEdited.TotalHit_Dat = int.Parse(tbCountHit_Dat.Text);

        //        dataBBEdited.FirstHitCheck = cbCountFirstHit.Checked;
        //        dataBBEdited.FirstHit_Gioi = int.Parse(tbFirstHit_Gioi.Text);
        //        dataBBEdited.FirstHit_Kha = int.Parse(tbFirstHit_Kha.Text);
        //        dataBBEdited.FirstHit_Dat = int.Parse(tbFirstHit_Dat.Text);

        //        dataBBEdited.BulletRemainsCheck = cbBulletRemains.Checked;
        //        dataBBEdited.BulletRemain_Gioi = cbBulletRemain_Gioi.Checked;
        //        dataBBEdited.BulletRemain_Kha = cbBulletRemain_Kha.Checked;
        //        dataBBEdited.BulletRemain_Dat = cbBulletRemain_Dat.Checked;

        //        return string.Empty;
        //    }
        //    catch (Exception)
        //    {
        //        return "Lỗi lấy thông tin điều kiện bài bắn";
        //    }
        //}

        public void ResetData()
        {
            InitData(originalData);
        }

        private void cbCountHit_CheckedChanged(object sender, EventArgs e)
        {
            tbCountHit_Gioi.Enabled = cbCountHit.Checked;
            tbCountHit_Kha.Enabled = cbCountHit.Checked;
            tbCountHit_Dat.Enabled = cbCountHit.Checked;

            if (!cbCountHit.Checked)
            {
                tbCountHit_Gioi.Text = "0";
                tbCountHit_Kha.Text = "0";
                tbCountHit_Dat.Text = "0";
            }
        }

        private void cbCountFirstHit_CheckedChanged(object sender, EventArgs e)
        {
            tbFirstHit_Gioi.Enabled = cbCountFirstHit.Checked;
            tbFirstHit_Kha.Enabled = cbCountFirstHit.Checked;
            tbFirstHit_Dat.Enabled = cbCountFirstHit.Checked;

            if (!cbCountFirstHit.Checked)
            {
                tbFirstHit_Gioi.Text = "0";
                tbFirstHit_Kha.Text = "0";
                tbFirstHit_Dat.Text = "0";
            }
        }

        private void cbBulletRemains_CheckedChanged(object sender, EventArgs e)
        {
            cbBulletRemain_Gioi.Enabled = cbBulletRemains.Checked;
            cbBulletRemain_Kha.Enabled = cbBulletRemains.Checked;
            cbBulletRemain_Dat.Enabled = cbBulletRemains.Checked;

            if (!cbBulletRemains.Checked)
            {
                cbBulletRemain_Gioi.Checked = false;
                cbBulletRemain_Kha.Checked = false;
                cbBulletRemain_Dat.Checked = false;
            }
        }
    }
}
