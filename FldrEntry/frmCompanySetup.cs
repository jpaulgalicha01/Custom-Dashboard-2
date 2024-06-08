using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Dashboard_2.FldrEntry
{
    public partial class frmCompanySetup : Form
    {
        public frmCompanySetup()
        {
            InitializeComponent();
        }

        private void frmCompanySetup_Load(object sender, EventArgs e)
        {

        }

        private void iconButton44_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton45_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
