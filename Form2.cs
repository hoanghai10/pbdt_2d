using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBDT_2D.Forms;
using TBDT_2D.Manager;

namespace TBDT_2D
{
    public partial class Form2 : Form
    {
        VS_User selectedUser;
        int currentEditRowIndex = -1;
        public Form2()
        {
            InitializeComponent();
            InitData();
            LoadGrdUsers();
        }

        void InitData()
        {
            var bindingLst = new List<VS_QuanHam>();
            bindingLst.Add(new VS_QuanHam
            {
                Id = 0,
                QuanHam = "All"
            });

            var lstQH = VS_DBManager.LoadAllQuanHams();
            bindingLst.AddRange(lstQH);

            //Binding
            filterQuanHam.ValueMember = "Id";
            filterQuanHam.DisplayMember = "QuanHam";
            filterQuanHam.DataSource = bindingLst;
        }

        void LoadGrdUsers()
        {
            var txtTen = filterTen.Text.Trim();
            var idQH = ((VS_QuanHam)filterQuanHam.SelectedItem).Id;
            var txtChucVu = filterChucVu.Text.Trim();
            var txtDonVi = filterDonVi.Text.Trim();
            var txtGhiChu = filterGhiChu.Text.Trim();

            var lst = VS_DBManager.LoadAllUsers(txtTen, idQH, txtChucVu, txtDonVi, txtGhiChu);

            grdUsers.AutoGenerateColumns = false;
            grdUsers.DataSource = lst;

            if (currentEditRowIndex != -1 && currentEditRowIndex < grdUsers.Rows.Count)
            {
                grdUsers.Rows[currentEditRowIndex].Selected = true;
                //grdUsers.FirstDisplayedScrollingRowIndex = currentEditRowIndex;
            }
        }
        void GetSelectedUser()
        {
            if (grdUsers.SelectedRows.Count == 1)
            {
                var result = new VS_User();

                result.Id = int.Parse(grdUsers.SelectedRows[0].Cells["Id"].Value.ToString());
                result.ThuTu = int.Parse(grdUsers.SelectedRows[0].Cells["ThuTu"].Value.ToString());
                result.Ten = grdUsers.SelectedRows[0].Cells["Ten"].Value.ToString();
                result.QuanHamId = int.Parse(grdUsers.SelectedRows[0].Cells["QuanHamId"].Value.ToString());
                result.QuanHam = grdUsers.SelectedRows[0].Cells["QuanHam"].Value.ToString();
                result.ChucVu = grdUsers.SelectedRows[0].Cells["ChucVu"].Value.ToString();
                result.DonVi = grdUsers.SelectedRows[0].Cells["DonVi"].Value.ToString();
                result.GhiChu = grdUsers.SelectedRows[0].Cells["GhiChu"].Value.ToString();

                selectedUser = result;
            }
            else
            {
                selectedUser = null;
            }
        }

        void AddNewUser()
        {
            if (grdUsers.Rows.Count == 0)
                currentEditRowIndex = 0;
            else
                currentEditRowIndex = grdUsers.Rows[grdUsers.Rows.Count - 1].Index;

            var data = new VS_User();
            var userAddEditForm = new VS_UserAddEdit(data);
            userAddEditForm.FormClosed += UserAddEditForm_FormClosed;
            userAddEditForm.ShowDialog();
        }

        void EditUser()
        {
            if (grdUsers.SelectedRows.Count == 1)
            {
                currentEditRowIndex = grdUsers.SelectedRows[0].Index;

                var userAddEditForm = new VS_UserAddEdit(selectedUser);
                userAddEditForm.FormClosed += UserAddEditForm_FormClosed;
                userAddEditForm.ShowDialog();
            }
        }

        void DeleteUser()
        {
            if (grdUsers.SelectedRows.Count == 1)
            {
                VS_DBManager.DeleteUser(selectedUser);
                LoadGrdUsers();
            }
        }

        #region Events
        private void grdUsers_SelectionChanged(object sender, EventArgs e)
        {
            GetSelectedUser();
        }

        private void filterTen_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void filterQuanHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void filterChucVu_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void filterDonVi_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void filterGhiChu_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            filterTen.Text = string.Empty;
            filterQuanHam.SelectedIndex = 0;
            filterChucVu.Text = string.Empty;
            filterDonVi.Text = string.Empty;
            filterGhiChu.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void grdUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdUsers.SelectedRows.Count == 1)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn XÓA người dùng này không ??",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteUser();
                }
            }
        }

        private void UserAddEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadGrdUsers();
            currentEditRowIndex = -1;
        }
        #endregion
    }
}
