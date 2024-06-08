using Custom_Dashboard_2.FldrMainMenu;
using System.Drawing;

namespace Custom_Dashboard_2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = true;
            }
            else
            {
                txtPassword.PasswordChar = false;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FrmMainMenu().Show();
            this.Hide();
        }
    }
}