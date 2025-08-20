using PBDT_2D;
using PBDT_2D.Forms;

namespace PBDT_2D
{
    public partial class VS_MainManager : Form
    {
        public VS_MainManager()
        {
            InitializeComponent();
        }
        private void btnHuanLuyen_Click(object sender, EventArgs e)
        {
            var a = new VS_Main();
            a.ShowDialog();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            var b = new UserManager();
            b.ShowDialog();
        }
    }

}
