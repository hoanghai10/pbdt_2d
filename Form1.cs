using TBDT.Forms;

namespace PBDT_2D
{
    public partial class Form1 : Form
    {
        public Form1()
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
            var b = new Form2();
            b.ShowDialog();
        }
    }

}
