using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBDT_2D.Forms;
using PBDT_2D.Manager;

namespace PBDT_2D
{
    public partial class UserManager : Form
    {
        VS_User selectedHV;
        VS_GiaoVu selectedGV;
        int currentEditRowIndex = -1;

        enum UserType
        {
            GiaoVu,
            HocVien
        }

        UserType currentType = UserType.GiaoVu;
        public UserManager()
        {
            InitializeComponent();
            InitData();
            LoadGrid(currentType);
        }
        void InitData()
        {
            // Binding cho combobox Quân hàm của cả 2 tab
            var bindingLst = new List<VS_QuanHam>();
            bindingLst.Add(new VS_QuanHam { Id = 0, QuanHam = "All" });
            bindingLst.AddRange(VS_DBManager.LoadAllQuanHams());

            filterQuanHamGV.ValueMember = "Id";
            filterQuanHamGV.DisplayMember = "QuanHam";
            filterQuanHamGV.DataSource = bindingLst.ToList();

            filterQuanHamHV.ValueMember = "Id";
            filterQuanHamHV.DisplayMember = "QuanHam";
            filterQuanHamHV.DataSource = bindingLst.ToList();
        }
        void LoadGrid(UserType type)
        {
            grdUsers.AutoGenerateColumns = false;

            if (type == UserType.HocVien)
            {
                var ten = filterTenHV.Text.Trim();
                var quanHamId = ((VS_QuanHam)filterQuanHamHV.SelectedItem).Id;
                var chucVu = filterChucVu.Text.Trim();
                var donVi = filterDonVi.Text.Trim();
                var ghiChu = filterGhiChu.Text.Trim();
                var namSinh = string.IsNullOrWhiteSpace(filterNamSinhHV.Text) ? (int?)null : int.Parse(filterNamSinhHV.Text);

                var lst = VS_DBManager.LoadAllUsers(ten, quanHamId, chucVu, donVi, ghiChu, namSinh);
                grdUsers.DataSource = lst;

                // Hiển thị cột phù hợp
                ChucVu.Visible = true;
                DonVi.Visible = true;
                GhiChu.Visible = true;
            }
            else // Giáo viên
            {
                var ten = filterTenGV.Text.Trim();
                var quanHamId = ((VS_QuanHam)filterQuanHamGV.SelectedItem).Id;
                var namSinh = string.IsNullOrWhiteSpace(filterNamSinhGV.Text) ? (int?)null : int.Parse(filterNamSinhGV.Text);

                var lst = VS_DBManager.LoadAllGiaoVu(quanHamId, ten, namSinh);
                grdUsers.DataSource = lst;

                // Hiển thị cột phù hợp
                ChucVu.Visible = false;
                DonVi.Visible = false;
                GhiChu.Visible = false;
            }

            if (currentEditRowIndex != -1 && currentEditRowIndex < grdUsers.Rows.Count)
            {
                grdUsers.Rows[currentEditRowIndex].Selected = true;
            }
        }

        void GetSelectedItem()
        {
            if (grdUsers.SelectedRows.Count == 1)
            {
                if (currentType == UserType.GiaoVu)
                    selectedGV = (VS_GiaoVu)grdUsers.SelectedRows[0].DataBoundItem;
                else
                    selectedHV = (VS_User)grdUsers.SelectedRows[0].DataBoundItem;
            }
            else
            {
                selectedGV = null;
                selectedHV = null;
            }
        }

        void AddNewItem()
        {
            if (grdUsers.Rows.Count == 0)
                currentEditRowIndex = 0;
            else
                currentEditRowIndex = grdUsers.Rows[grdUsers.Rows.Count - 1].Index;

            if (currentType == UserType.GiaoVu)
            {
                var dataGV = new VS_GiaoVu();
                var form = new VS_GiaoVuAddEdit(dataGV);
                form.FormClosed += UserAddEditForm_FormClosed;
                form.ShowDialog();
            }
            else
            {
                var dataHV = new VS_User();
                var form = new VS_UserAddEdit(dataHV);
                form.FormClosed += UserAddEditForm_FormClosed;
                form.ShowDialog();
            }
        }

        void EditItem()
        {
            if (grdUsers.SelectedRows.Count == 1)
            {
                currentEditRowIndex = grdUsers.SelectedRows[0].Index;

                if (currentType == UserType.GiaoVu && selectedGV != null)
                {
                    var form = new VS_GiaoVuAddEdit(selectedGV);
                    form.FormClosed += UserAddEditForm_FormClosed;
                    form.ShowDialog();
                }
                else if (currentType == UserType.HocVien && selectedHV != null)
                {
                    var form = new VS_UserAddEdit(selectedHV);
                    form.FormClosed += UserAddEditForm_FormClosed;
                    form.ShowDialog();
                }
            }
        }

        void DeleteItem()
        {
            if (currentType == UserType.GiaoVu && selectedGV != null)
            {
                VS_DBManager.DeleteGiaoVu(selectedGV);
            }
            else if (currentType == UserType.HocVien && selectedHV != null)
            {
                VS_DBManager.DeleteUser(selectedHV);
            }
            LoadGrid(currentType);
        }

        #region Events
        private void grdUsers_SelectionChanged(object sender, EventArgs e)
        {
            GetSelectedItem();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadGrid(currentType);
        }

        private void btnResetFilterGV_Click(object sender, EventArgs e)
        {
            
            filterTenGV.Text = string.Empty;
            filterQuanHamHV.SelectedIndex = 0;
            filterNamSinhGV.Text = string.Empty;
        }

        private void btnResetFilterHV_Click(object sender, EventArgs e)
        {
            filterTenHV.Text = string.Empty;
            filterQuanHamHV.SelectedIndex = 0;
            filterChucVu.Text = string.Empty;
            filterDonVi.Text = string.Empty;
            filterGhiChu.Text = string.Empty;
            filterNamSinhHV.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void grdUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn XÓA bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteItem();
            }
        }

        private void UserAddEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadGrid(currentType);
            currentEditRowIndex = -1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentType = tabControl1.SelectedTab == tabQLGQ ? UserType.GiaoVu : UserType.HocVien;
            if(currentType == UserType.GiaoVu)
            {
                grdUsers.Columns["HoTen"].DataPropertyName = "HoTen";
            }
            else
            {
                grdUsers.Columns["HoTen"].DataPropertyName = "Ten";
            }
            LoadGrid(currentType);
        }
        #endregion
    }
}
