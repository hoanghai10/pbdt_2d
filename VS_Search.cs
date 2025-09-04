using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PBDT_2D.Manager;

namespace PBDT_2D.Forms
{
    public partial class VS_Search : Form
    {
        public VS_Search()
        {
            InitializeComponent();
            InitData();
            LoadGrdCrews();
        }

        #region Methods
        void InitData()
        {
            //load loai sung
            var lstGun = VS_DBManager.LoadDanhSachSung();
            lstGun.Insert(0, new VS_LoaiSung { Id = "", Name = "" });

            cond_cboGunType.DataSource = lstGun;
            cond_cboGunType.DisplayMember = "Name";
            cond_cboGunType.ValueMember = "Id";

            //load teacher list
            var lstUser = VS_DBManager.LoadAllGiaoVu( 0, "",0);
            lstUser.Insert(0, new VS_GiaoVu { Id = 0, HoTen = "" });

            cond_cboTeacher.DataSource = lstUser;
            cond_cboTeacher.DisplayMember = "Ten";
            cond_cboTeacher.ValueMember = "Id";

            //format datetime cell
            grdCrews.Columns["KB_ThoiGianBatDau"].DefaultCellStyle.Format = VS_DBManager.DBDateTimeFormat;
            grdSearchResult.Columns["TGBatDau"].DefaultCellStyle.Format = VS_DBManager.DBDateTimeFormat;
            grdSearchResult.Columns["TGKetThuc"].DefaultCellStyle.Format = VS_DBManager.DBDateTimeFormat;
        }

        void LoadGrdCrews()
        {
            var dateFrom = cond_dpFrom.Value.Date;//from start day
            var dateTo = cond_dpTo.Value.Date.AddDays(1).AddSeconds(-1);//to end of day
            var idSung = cond_cboGunType.SelectedItem == null ? "" : ((VS_LoaiSung)cond_cboGunType.SelectedItem).Id;
            var idBB = cond_cboEx.SelectedItem == null ? "" : ((VS_Baiban)cond_cboEx.SelectedItem).Id;
            var idTeacher = cond_cboTeacher.SelectedItem == null ? 0 : ((VS_GiaoVu)cond_cboTeacher.SelectedItem).Id;

            var searchConds = new VS_SearchConditions
            {
                From = dateFrom,
                To = dateTo,
                IdSung = idSung,
                IdBaiBan = idBB,
                IdTeacher = idTeacher
            };

            var rs = VS_DBManager.LoadDSKipBan(searchConds);
            grdCrews.DataSource = rs;
        }
        #endregion

        #region Events
        private void cond_dpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadGrdCrews();
        }

        private void cond_dpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadGrdCrews();
        }

        private void cond_cboGunType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lstEx = VS_DBManager.LoadDSBBTheoLoaiSung(((VS_LoaiSung)cond_cboGunType.SelectedItem).Id);
            lstEx.Insert(0, new VS_Baiban { Id = "", TenBB = "" });

            cond_cboEx.DataSource = lstEx;
            cond_cboEx.DisplayMember = "TenBB";
            cond_cboEx.ValueMember = "Id";

            LoadGrdCrews();
        }

        private void cond_cboEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrdCrews();
        }

        private void cond_cboTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrdCrews();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var dateFrom = cond_dpFrom.Value.Date;//from start day
                var dateTo = cond_dpTo.Value.Date.AddDays(1).AddSeconds(-1);//to end of day
                var idSung = cond_cboGunType.SelectedItem == null ? "" : ((VS_LoaiSung)cond_cboGunType.SelectedItem).Id;
                var idBB = cond_cboEx.SelectedItem == null ? "" : ((VS_Baiban)cond_cboEx.SelectedItem).Id;
                var idTeacher = cond_cboTeacher.SelectedItem == null ? 0 : ((VS_User)cond_cboTeacher.SelectedItem).Id;
                var idKbLst = new List<string>();
                foreach (DataGridViewRow r in grdCrews.Rows)
                {
                    if (bool.Parse(r.Cells["KB_IsSelected"].Value.ToString()))
                        idKbLst.Add(r.Cells["KB_Id"].Value.ToString());
                }

                var searchConds = new VS_SearchConditions
                {
                    From = dateFrom,
                    To = dateTo,
                    IdSung = idSung,
                    IdBaiBan = idBB,
                    IdKBRange = string.Join(",", idKbLst),
                    IdTeacher = idTeacher
                };

                var rs = VS_DBManager.SearchResultByCondtions(searchConds);
                grdSearchResult.DataSource = rs;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hiện kết quả bắn");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var pp = new VS_PrintPreview(grdSearchResult);
            pp.ShowDialog();
        }



        #endregion

        
    }
}
