using PBDT_2D.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PBDT_2D.Manager.VS_HABBFormData;

namespace PBDT_2D
{
    public partial class KipBan : Form
    {
        public KipBan()
        {
            InitializeComponent();
            grdTeacher.ScrollBars = ScrollBars.None;
        }

        private void KipBan_Load(object sender, EventArgs e)
        {
            var (hvTable, gvTable) = VS_DBManager.LoadSelectedUsers(
            SelectedDataStore.HocVienIds,
            SelectedDataStore.GiaoVuIds);

            grdUsersShooting.DataSource = hvTable;
            grdTeacher.DataSource = gvTable;
        }
    }
}
