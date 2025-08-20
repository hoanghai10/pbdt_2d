using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TBA2D.Forms.UserControls
{
    public partial class VS_DieuKienBia : UserControl
    {
        string originalHien;
        string originalAn;

        public VS_DieuKienBia()
        {
            InitializeComponent();
        }

        public void InitData(string bia, string thoiGian)
        {
            gbBia.Text = string.Format("Bia {0}", bia);

            var arr = thoiGian.Split('-').ToList();
            if (arr.Count == 2)
            {
                tbHien.Text = arr[0];
                tbAn.Text = arr[1];

                originalHien = arr[0];
                originalAn = arr[1];
            }
        }

        public string GetData(out string result)
        {
            try
            {
                result = string.Empty;

                //check empty
                if (string.IsNullOrWhiteSpace(tbHien.Text) || string.IsNullOrWhiteSpace(tbAn.Text))
                    return "Chưa nhập dữ liệu";

                var lstHien = tbHien.Text.Split(',').ToList();
                var lstAn = tbAn.Text.Split(',').ToList();

                //check is number
                for (int i = 0; i < lstHien.Count; i++)
                    if (!int.TryParse(lstHien[i], out int tmp))
                        return "Mốc thời gian phải là số nguyên";

                for (int i = 0; i < lstAn.Count; i++)
                    if (!int.TryParse(lstAn[i], out int tmp))
                        return "Mốc thời gian phải là số nguyên";

                //check same quantity
                if (lstHien.Count != lstAn.Count)
                    return "Số lượng mốc thời gian phải bằng nhau";

                result = string.Format("{0}-{1}", tbHien.Text.Trim(), tbAn.Text.Trim());
                return string.Empty;
            }
            catch (Exception)
            {
                result = string.Empty;
                return "Lỗi lấy thông tin điều kiện bài bắn";
            }
        }

        public void ResetData()
        {
            tbHien.Text = originalHien;
            tbAn.Text = originalAn;
        }
    }
}
