using PBDT_2D.Forms;
using PBDT_2D.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PBDT_2D.Manager.VS_HABBFormData;

namespace PBDT_2D
{
    public partial class VS_DanhSachPhuTrach : Form
    {
        VS_User userList_selectedUser;
        VS_User userShootingList_selectedUser;
        VS_GiaoVu teacherList_selectedUser;
        int userShooting_selectedUserIndex = -1;
        bool setupForExercise;
        public VS_DanhSachPhuTrach()
        {
            setupForExercise = false;

            InitializeComponent();
            InitData();
            lblSetupTitle.Text = string.Format("THIẾT LẬP KÍP BẮN");

        }
        void InitData()
        {
            //setup gun grid
            var lstGun = new List<VS_BindingGun>();
            for (int i = 1; i <= 9; i++)
            {
                lstGun.Add(new VS_BindingGun { GunId = i });
            }
            grdSung.DataSource = lstGun;

            //setup shooting users grid
            var lstShootingUsers = new List<VS_User>();
            for (int i = 1; i <= 9; i++)
            {
                lstShootingUsers.Add(new VS_User());
            }
            grdUsersShooting.DataSource = lstShootingUsers;

            //setup teacher grid
            var lstTeacherUsers = new List<VS_GiaoVu> { new VS_GiaoVu() };
            grdTeacher.DataSource = lstTeacherUsers;

            //binding cbo filter quan ham
            var bindingLst = new List<VS_QuanHam>();
            bindingLst.Add(new VS_QuanHam
            {
                Id = 0,
                QuanHam = "All"
            });

            var lstQH = VS_DBManager.LoadAllQuanHams();
            bindingLst.AddRange(lstQH);
            cboFilterQuanHamHv.ValueMember = "Id";
            cboFilterQuanHamHv.DisplayMember = "QuanHam";
            cboFilterQuanHamHv.DataSource = bindingLst.ToList();

            cbFilterQuanHamGv.ValueMember = "Id";
            cbFilterQuanHamGv.DisplayMember = "QuanHam";
            cbFilterQuanHamGv.DataSource = bindingLst.ToList();

            //Load user list
            LoadGrdUsers();
            LoadGrdGiaoVu();
        }

        void LoadGrdUsers()
        {
            var txtTen = tbFilterTenHv.Text.Trim();
            var idQH = ((VS_QuanHam)cboFilterQuanHamHv.SelectedItem).Id;
            var txtChucVu = tbFilterChucVu.Text.Trim();
            var txtDonVi = tbFilterDonVi.Text.Trim();
            var txtGhiChu = tbFilterGhiChu.Text.Trim();
            var namSinh = string.IsNullOrWhiteSpace(tbFilterNamSinhHv.Text) ? (int?)null : int.Parse(tbFilterNamSinhHv.Text);
            var lst = VS_DBManager.LoadAllUsers(txtTen, idQH, txtChucVu, txtDonVi, txtGhiChu, namSinh);

            grdUsersList.AutoGenerateColumns = false;
            grdUsersList.DataSource = lst;
        }

        void LoadGrdGiaoVu()
        {
            var ten = tbFilterTenGv.Text.Trim();
            var quanHamId = ((VS_QuanHam)cbFilterQuanHamGv.SelectedItem).Id;
            var namSinh = string.IsNullOrWhiteSpace(tbFilterNamSinhGv.Text) ? (int?)null : int.Parse(tbFilterNamSinhGv.Text);
            var lst = VS_DBManager.LoadAllGiaoVu(quanHamId, ten, namSinh);

            grdGiaoVienList.AutoGenerateColumns = false;
            grdGiaoVienList.DataSource = lst;
        }

        void UserList_GetSelectedUser()
        {
            if (grdUsersList.SelectedRows.Count == 1)
            {
                var result = new VS_User();

                result.Id = int.Parse(grdUsersList.SelectedRows[0].Cells["userList_Id"].Value.ToString());
                result.ThuTu = int.Parse(grdUsersList.SelectedRows[0].Cells["userList_ThuTu"].Value.ToString());
                result.Ten = grdUsersList.SelectedRows[0].Cells["userList_Ten"].Value.ToString();
                result.QuanHamId = int.Parse(grdUsersList.SelectedRows[0].Cells["userList_QuanHamId"].Value.ToString());
                result.QuanHam = grdUsersList.SelectedRows[0].Cells["userList_QuanHam"].Value.ToString();
                result.ChucVu = grdUsersList.SelectedRows[0].Cells["userList_ChucVu"].Value.ToString();
                result.DonVi = grdUsersList.SelectedRows[0].Cells["userList_DonVi"].Value.ToString();
                result.GhiChu = grdUsersList.SelectedRows[0].Cells["userList_GhiChu"].Value.ToString();
                var cellValue = grdUsersList.SelectedRows[0].Cells["userList_NamSinh"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int namSinh))
                    result.NamSinh = namSinh;
                else
                    result.NamSinh = null;

                userList_selectedUser = result;
            }
            else
            {
                userList_selectedUser = null;
            }
        }
        void GiaoVuList_GetSelectedUser()
        {
            if (grdGiaoVienList.SelectedRows.Count == 1)
            {
                var result = new VS_GiaoVu();

                result.Id = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_Id"].Value.ToString());
                result.ThuTu = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_ThuTu"].Value.ToString());
                result.HoTen = grdGiaoVienList.SelectedRows[0].Cells["gvList_Ten"].Value.ToString();
                result.QuanHamId = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_QuanHamId"].Value.ToString());
                result.QuanHam = grdGiaoVienList.SelectedRows[0].Cells["gvList_QuanHam"].Value.ToString();
                result.NamSinh = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_NamSinh"].Value.ToString());

                teacherList_selectedUser = result;
            }
            else
            {
                teacherList_selectedUser = null;
            }
        }

        void UserShootingList_GetSelectedUser()
        {
            if (grdUsersShooting.SelectedRows.Count == 1)
            {
                var result = new VS_User();

                result.Id = int.Parse(grdUsersShooting.SelectedRows[0].Cells["Id"].Value.ToString());
                result.ThuTu = int.Parse(grdUsersShooting.SelectedRows[0].Cells["ThuTu"].Value.ToString());
                result.Ten = grdUsersShooting.SelectedRows[0].Cells["Ten"].Value.ToString();
                result.QuanHamId = int.Parse(grdUsersShooting.SelectedRows[0].Cells["QuanHamId"].Value.ToString());
                result.QuanHam = grdUsersShooting.SelectedRows[0].Cells["QuanHam"].Value.ToString();
                result.ChucVu = grdUsersShooting.SelectedRows[0].Cells["ChucVu"].Value.ToString();
                result.DonVi = grdUsersShooting.SelectedRows[0].Cells["DonVi"].Value.ToString();
                result.GhiChu = grdUsersShooting.SelectedRows[0].Cells["GhiChu"].Value.ToString();
                var cellValue = grdUsersShooting.SelectedRows[0].Cells["NamSinh"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int namSinh))
                    result.NamSinh = namSinh;
                else
                    result.NamSinh = null;


                userShootingList_selectedUser = result;
                userShooting_selectedUserIndex = grdUsersShooting.SelectedRows[0].Index;
            }
            else
            {
                userShootingList_selectedUser = null;
                userShooting_selectedUserIndex = -1;
            }
        }

        void TeacherList_GetSelectedUser()
        {
            if (grdTeacher.SelectedRows.Count == 1)
            {
                var result = new VS_GiaoVu();

                result.Id = int.Parse(grdTeacher.SelectedRows[0].Cells["teacher_Id"].Value.ToString());
                result.ThuTu = int.Parse(grdTeacher.SelectedRows[0].Cells["teacher_ThuTu"].Value.ToString());
                result.HoTen = grdTeacher.SelectedRows[0].Cells["teacher_Ten"].Value.ToString();
                result.QuanHamId = int.Parse(grdTeacher.SelectedRows[0].Cells["teacher_QuanHamId"].Value.ToString());
                result.QuanHam = grdTeacher.SelectedRows[0].Cells["teacher_QuanHam"].Value.ToString();
                var cellValue = grdTeacher.SelectedRows[0].Cells["teacher_NamSinh"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int namSinh))
                    result.NamSinh = namSinh;
                else
                    result.NamSinh = null;

                Debug.WriteLine($"[Teacher] STT: {result.ThuTu}, Id: {result.Id} QHId: {result.QuanHamId}, HoTen: {result.HoTen}, NamSinh: {result.NamSinh}, QuanHam: {result.QuanHam}");

                teacherList_selectedUser = result;
            }
            else
            {
                teacherList_selectedUser = null;
            }
        }

        void PushSelectedUserToShootingGrids()
        {
            if (userList_selectedUser == null) return;

            List<VS_User> fooS = (List<VS_User>)grdUsersShooting.DataSource;
            //List<VS_GiaoVu> fooT = (List<VS_GiaoVu>)grdTeacher.DataSource;

            //Check if user in shooting list
            if (fooS.Any(u => u.Id == userList_selectedUser.Id))
            {
                MessageBox.Show("Người dùng đã có trong danh sách kíp bắn!");
                return;
            }

            //Check if user selected to be teacher
            //if (fooT.Any(u => u.Id == userList_selectedUser.Id))
            //{
            //    MessageBox.Show("Người dùng đã được chọn làm quản lý kíp bắn!");
            //    return;
            //}

            //Check empty row to push data
            int emptyIndex = fooS.FindIndex(u => u.Id == 0);
            if (emptyIndex == -1)
            {
                MessageBox.Show("Danh sách kíp bắn đã đủ!");
                return;
            }

            fooS[emptyIndex] = userList_selectedUser;
            grdUsersShooting.DataSource = fooS;
            grdUsersShooting.Refresh();
        }

        void PushSelectedUserToTeacherGrids()
        {
            if (userList_selectedUser == null) return;

            //List<VS_User> fooS = (List<VS_User>)grdUsersShooting.DataSource;
            List<VS_GiaoVu> fooT = (List<VS_GiaoVu>)grdTeacher.DataSource;

            //Check if user in shooting list
            //if (fooS.Any(u => u.Id == userList_selectedUser.Id))
            //{
            //    MessageBox.Show("Người dùng đã có trong danh sách kíp bắn!");
            //    return;
            //}

            if (fooT.Count == 0) fooT.Add(new VS_GiaoVu());

            fooT[0] = teacherList_selectedUser;
            grdTeacher.DataSource = fooT;
            grdTeacher.Refresh();
        }

        string SerializeShootingSetupToIdString()
        {
            List<VS_User> foo = (List<VS_User>)grdUsersShooting.DataSource;
            List<VS_GiaoVu> foo2 = (List<VS_GiaoVu>)grdTeacher.DataSource;

            var str = string.Join(",", foo.Select(u => u.Id).ToList());
            str = str + "|" + (teacherList_selectedUser != null ? teacherList_selectedUser.Id : 0);

            return str;
        }


        void UserShooting_SwapRows(int fromIndex, int changeTo)
        {
            List<VS_User> foo = (List<VS_User>)grdUsersShooting.DataSource;

            var tmp = foo[fromIndex];
            foo[fromIndex] = foo[changeTo];
            foo[changeTo] = tmp;

            grdUsersShooting.DataSource = foo;
            grdUsersShooting.Refresh();

            grdUsersShooting.Rows[changeTo].Selected = true;
        }

        //List<VS_User> GetShootingSetupList()
        //{
        //    if (cbSetupCrew.Checked)
        //    {
        //        List<VS_User> foo = (List<VS_User>)grdUsersShooting.DataSource;
        //        return foo;
        //    }
        //    else
        //    {
        //        List<VS_User> foo = new List<VS_User>();
        //        for (int i = 0; i < 9; i++)
        //        {
        //            foo.Add(new VS_User());
        //        }
        //        return foo;
        //    }
        //}

        void ParseSetupToShootingList(string setupStr)
        {
            var arr = setupStr.Split('|').ToArray();

            if (arr.Length == 2)
            {
                var lstUserIds = arr[0].Split(',').Select(x => int.Parse(x)).ToList();
                var teacherId = int.Parse(arr[1]);

                var userList = (List<VS_User>)grdUsersList.DataSource;
                var giaoVienList = (List<VS_GiaoVu>)grdGiaoVienList.DataSource;

                //users
                var foo = new List<VS_User>();
                for (int i = 0; i < lstUserIds.Count; i++)
                {
                    var user = userList.FirstOrDefault(u => u.Id == lstUserIds[i]);
                    foo.Add(user == null ? new VS_User() : user);
                }

                grdUsersShooting.DataSource = foo;
                grdUsersShooting.Refresh();

                //teacher
                var foo2 = new List<VS_GiaoVu>();
                var teacher = giaoVienList.FirstOrDefault(u => u.Id == teacherId);
                foo2.Add(teacher == null ? new VS_GiaoVu() : teacher);

                grdTeacher.DataSource = foo2;
                grdTeacher.Refresh();
            }
        }

        #region Events

        public event Action<string> OnSetupSaved;

        //when close form
        private void VS_CrewSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (setupForExercise)
            {
                VS_Main mf = (VS_Main)Application.OpenForms["VS_Main"];
                mf.EndPreviewBB();
            }

        }



        private void tbFilterTen_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void cboFilterQuanHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void tbFilterChucVu_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void tbFilterDonVi_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void tbFilterGhiChu_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void tbFilterNamSinhHv_TextChanged(object sender, EventArgs e)
        {
            LoadGrdUsers();
        }

        private void tbFilterTenGv_TextChanged(object sender, EventArgs e)
        {
            LoadGrdGiaoVu();
        }

        private void cbFilterQuanHamGv_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrdGiaoVu();
        }

        private void tbFilterNamSinhGv_TextChanged(object sender, EventArgs e)
        {
            LoadGrdGiaoVu();
        }
        private void grdGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            GiaoVuList_GetSelectedUser();
        }

        private void grdUsersList_SelectionChanged(object sender, EventArgs e)
        {
            UserList_GetSelectedUser();
        }

        private void grdTeacher_SelectionChanged(object sender, EventArgs e)
        {
            TeacherList_GetSelectedUser();
        }

        private void grdUsersShooting_SelectionChanged(object sender, EventArgs e)
        {
            if (grdUsersShooting.SelectedRows.Count > 0)
                grdSung.Rows[grdUsersShooting.SelectedRows[0].Index].Selected = true;

            UserShootingList_GetSelectedUser();
        }

        private void grdSung_SelectionChanged(object sender, EventArgs e)
        {
            if (grdSung.SelectedRows.Count > 0)
                grdUsersShooting.Rows[grdSung.SelectedRows[0].Index].Selected = true;
        }

        //Push user to shooting list
        private void btnPickCrew_Click(object sender, EventArgs e)
        {
            PushSelectedUserToShootingGrids();
            UserShootingList_GetSelectedUser();
        }

        //Push user to teacher list
        private void btnPickTeacher_Click(object sender, EventArgs e)
        {
            PushSelectedUserToTeacherGrids();
            TeacherList_GetSelectedUser();
        }

        //Remove user from shooting list
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (userShootingList_selectedUser != null)
            {
                List<VS_User> foo = (List<VS_User>)grdUsersShooting.DataSource;
                var index = foo.FindIndex(u => u.Id == userShootingList_selectedUser.Id);
                if (index != -1)
                    foo[index] = new VS_User();

                grdUsersShooting.DataSource = foo;
                grdUsersShooting.Refresh();
            }
        }

        //Remove user from teacher list
        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            List<VS_GiaoVu> foo = (List<VS_GiaoVu>)grdTeacher.DataSource;
            if (foo.Count >= 1)
                foo[0] = new VS_GiaoVu();

            grdTeacher.DataSource = foo;
            grdTeacher.Refresh();
        }

        //Rearrange shooting user list - up
        private void btnUserUp_Click(object sender, EventArgs e)
        {
            if (userShooting_selectedUserIndex > 0)
                UserShooting_SwapRows(userShooting_selectedUserIndex, userShooting_selectedUserIndex - 1);
        }

        //Rearrange shooting user list - down
        private void btnUserDown_Click(object sender, EventArgs e)
        {
            if (userShooting_selectedUserIndex < 8)
                UserShooting_SwapRows(userShooting_selectedUserIndex, userShooting_selectedUserIndex + 1);
        }



        private void btnResetFilterHv_Click(object sender, EventArgs e)
        {
            tbFilterTenHv.Text = string.Empty;
            cboFilterQuanHamHv.SelectedIndex = 0;
            tbFilterChucVu.Text = string.Empty;
            tbFilterDonVi.Text = string.Empty;
            tbFilterGhiChu.Text = string.Empty;
            tbFilterNamSinhHv.Text = string.Empty;

        }

        private void btnResetFilterGv_Click(object sender, EventArgs e)
        {
            tbFilterTenGv.Text = string.Empty;
            cbFilterQuanHamGv.SelectedIndex = 0;
            tbFilterNamSinhGv.Text = string.Empty;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var folderPath = string.Format("{0}\\{1}", Path.GetDirectoryName(Application.ExecutablePath), VS_Helper.DefaultCrewSetupFileFolder);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                var ofd = new OpenFileDialog() { InitialDirectory = folderPath };
                ofd.Title = "Chọn file cài đặt kíp bắn";
                ofd.Filter = "All files (*.*) | *.setup";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    string extesion = Path.GetExtension(fileName);
                    switch (extesion)
                    {
                        case ".setup":
                            var content = VS_Helper.ReadFileContent(fileName);
                            ParseSetupToShootingList(content);
                            break;
                        default:
                            MessageBox.Show("Đuôi file mở không đúng định dạng");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc thiết lập kíp bắn lỗi");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SelectedDataStore.HocVienIds = grdUsersShooting.Rows
            .Cast<DataGridViewRow>()
            .Where(r => r.Cells["Id"].Value != null)   // tránh null
            .Select(r => Convert.ToInt32(r.Cells["Id"].Value))
            .ToList();

            SelectedDataStore.GiaoVuIds = grdTeacher.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(r => (int)r.Cells["teacher_Id"].Value)
                    .ToList();

            this.Close(); // Quay về Form Main


            //try
            //{
            //    var folderPath = string.Format("{0}\\{1}", Path.GetDirectoryName(Application.ExecutablePath), VS_Helper.DefaultCrewSetupFileFolder);
            //    if (!Directory.Exists(folderPath))
            //        Directory.CreateDirectory(folderPath);

            //    var sfd = new SaveFileDialog() { InitialDirectory = folderPath };
            //    sfd.Title = "Lưu thiết lập kíp bắn ra file";
            //    sfd.Filter = "All files (*.*) | *.setup";
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        string fileName = sfd.FileName;
            //        string extesion = Path.GetExtension(fileName);
            //        switch (extesion)
            //        {
            //            case ".setup":
            //                VS_Helper.WriteContentToFile(fileName, SerializeShootingSetupToIdString());
            //                OnSetupSaved?.Invoke(fileName);
            //                break;
            //            default:
            //                MessageBox.Show("Đuôi file lưu không đúng định dạng");
            //                break;
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Lưu thiết lập kíp bắn lỗi");
            //}
        }

        #endregion

    }
}
