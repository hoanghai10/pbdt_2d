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
            if (grdGiaoVienList.SelectedRows.Count == 1)
            {
                var result = new VS_GiaoVu();

                result.Id = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_Id"].Value.ToString());
                result.ThuTu = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_ThuTu"].Value.ToString());
                result.HoTen = grdGiaoVienList.SelectedRows[0].Cells["gvList_Ten"].Value.ToString();
                result.QuanHamId = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_QuanHamId"].Value.ToString());
                result.QuanHam = grdGiaoVienList.SelectedRows[0].Cells["gvList_QuanHam"].Value.ToString();
                result.NamSinh = int.Parse(grdGiaoVienList.SelectedRows[0].Cells["gvList_NamSinh"].Value.ToString());

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

        // Lưu session học viên
        void SaveShootingSessionHV()
        {
            var foo = (List<VS_User>)grdUsersShooting.DataSource;
            string str = string.Join(",", foo.Select(u => u.Id).ToList());

            Properties.Settings.Default.LastShootingSession_HV = str;
            Properties.Settings.Default.Save();
        }

        // Lưu session giáo vụ
        void SaveShootingSessionGV()
        {
            var foo2 = (List<VS_GiaoVu>)grdTeacher.DataSource;
            int teacherId = teacherList_selectedUser != null ? teacherList_selectedUser.Id : 0;

            Properties.Settings.Default.LastShootingSession_GV = teacherId.ToString();
            Properties.Settings.Default.Save();
        }
        void LoadShootingSessionHV()
        {
            string str = Properties.Settings.Default.LastShootingSession_HV;
            var lstResult = new List<VS_User>();

            // Nếu có dữ liệu đã lưu
            if (!string.IsNullOrEmpty(str))
            {
                var ids = str.Split(',')
                             .Where(x => !string.IsNullOrWhiteSpace(x))
                             .Select(int.Parse)
                             .ToList();

                if (ids.Count > 0)
                {
                    // Lấy toàn bộ HV từ DB
                    var lstAllUsers = VS_DBManager.LoadAllUsers("", 0, "", "", "", null);

                    // Duyệt qua 9 slot
                    for (int i = 0; i < 9; i++)
                    {
                        if (i < ids.Count)
                        {
                            // Nếu Id hợp lệ -> lấy user từ DB
                            var user = lstAllUsers.FirstOrDefault(u => u.Id == ids[i]);
                            lstResult.Add(user ?? new VS_User());
                        }
                        else
                        {
                            // Nếu không có id -> slot trống
                            lstResult.Add(new VS_User());
                        }
                    }
                }
            }

            // Nếu chưa có dữ liệu -> tạo 9 slot trống
            if (lstResult.Count == 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    lstResult.Add(new VS_User());
                }
            }

            grdUsersShooting.AutoGenerateColumns = false;
            grdUsersShooting.DataSource = lstResult;
        }



        void LoadShootingSessionGV()
        {
            string str = Properties.Settings.Default.LastShootingSession_GV;
            if (string.IsNullOrEmpty(str)) return;

            int teacherId = int.Parse(str);

            // Lấy toàn bộ danh sách GV
            var lstAllTeachers = VS_DBManager.LoadAllGiaoVu(0, "", null);

            // Tìm lại GV đã lưu
            var selectedTeacher = lstAllTeachers.FirstOrDefault(t => t.Id == teacherId);

            if (selectedTeacher != null)
            {
                // Bind lại cho Grid
                grdTeacher.AutoGenerateColumns = false;
                grdTeacher.DataSource = new List<VS_GiaoVu> { selectedTeacher };

                // Gán lại biến selectedUser
                teacherList_selectedUser = selectedTeacher;
            }
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
                var foo2 = new List<VS_User>();
                var teacher = userList.FirstOrDefault(u => u.Id == teacherId);
                foo2.Add(teacher == null ? new VS_User() : teacher);

                grdTeacher.DataSource = foo2;
                grdTeacher.Refresh();
            }
        }

        #region Events

        //when close form
        private void VS_CrewSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (setupForExercise)
            {
                VS_Main mf = (VS_Main)Application.OpenForms["VS_Main"];
                mf.EndPreviewBB();
            }
            SaveShootingSessionHV();
            SaveShootingSessionGV();
        }
        private void VS_CrewSetup_Load(object sender, EventArgs e)
        {
            LoadShootingSessionHV();
            LoadShootingSessionGV();
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
        #endregion
    }
}
