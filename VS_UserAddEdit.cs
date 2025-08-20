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
    public partial class VS_UserAddEdit : Form
    {
        VS_User currentEditUserData;

        public VS_UserAddEdit()
        {
            InitializeComponent();
        }

        public VS_UserAddEdit(VS_User data)
        {
            InitializeComponent();
            InitData(data);
        }

        void InitData(VS_User data)
        {
            //Change form text
            this.Text = data.Id == 0 ? "THÊM NGƯỜI DÙNG" : "CHỈNH SỬA THÔNG TIN NGƯỜI DÙNG";

            //Binding cbo data
            var bindingLst = new List<VS_QuanHam>();
            bindingLst.Add(new VS_QuanHam
            {
                Id = 0,
                QuanHam = ""
            });

            var lstQH = VS_DBManager.LoadAllQuanHams();
            bindingLst.AddRange(lstQH);

            cboQuanHam.ValueMember = "Id";
            cboQuanHam.DisplayMember = "QuanHam";
            cboQuanHam.DataSource = bindingLst;

            //Populate data
            currentEditUserData = VS_Helper.Clone<VS_User>(data);

            tbTen.Text = data.Ten;
            cboQuanHam.SelectedValue = data.QuanHamId;
            tbChucVu.Text = data.ChucVu;
            tbDonVi.Text = data.DonVi;
            tbGhiChu.Text = data.GhiChu;
            tbNamsinh.Text = data.NamSinh.ToString();
        }

        void CloseForm()
        {
            currentEditUserData = null;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Data validation
            if (string.IsNullOrWhiteSpace(tbTen.Text))
            {
                MessageBox.Show("Chưa nhập tên!");
                return;
            }

            if (((VS_QuanHam)cboQuanHam.SelectedItem).Id == 0)
            {
                MessageBox.Show("Chưa nhập quân hàm!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNamsinh.Text) || !int.TryParse(tbNamsinh.Text.Trim(), out int namSinh))
            {
                MessageBox.Show("Năm sinh không hợp lệ!");
                return;
            }

            //Update data to DB
            currentEditUserData.Ten = tbTen.Text.Trim();
            currentEditUserData.QuanHamId = ((VS_QuanHam)cboQuanHam.SelectedItem).Id;
            currentEditUserData.ChucVu = tbChucVu.Text.Trim();
            currentEditUserData.DonVi = tbDonVi.Text.Trim();
            currentEditUserData.GhiChu = tbGhiChu.Text.Trim();
            currentEditUserData.NamSinh = namSinh;

            if (VS_DBManager.AddEditUser(currentEditUserData))
                CloseForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
