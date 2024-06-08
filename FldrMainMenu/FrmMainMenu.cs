using Custom_Dashboard_2.FldFile;
using Custom_Dashboard_2.FldrClass;
using Custom_Dashboard_2.FldrEntry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Dashboard_2.FldrMainMenu
{
    public partial class FrmMainMenu : Form
    {
        bool sideMenuCollapse;
        Panel PanelName = new Panel();
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            showContent(new frmDashboard());
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sideMenuCollapse)
            {
                PanelName.Height += 10;
                if (PanelName.Height == PanelName.MaximumSize.Height)
                {
                    sideMenuCollapse = false;
                    sidebarTimer.Stop();

                }
            }
            else
            {
                PanelName.Height -= 10;
                if (PanelName.Height == PanelName.MinimumSize.Height)
                {
                    sideMenuCollapse = true;
                    sidebarTimer.Stop();

                }
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

            PanelName = entryContainer;
            sidebarTimer.Start();
        }



        private void iconButton7_Click(object sender, EventArgs e)
        {
            PanelName = filePanel;
            sidebarTimer.Start();
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            PanelName = employeePanel;
            sidebarTimer.Start();
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            PanelName = preparationPanel;
            sidebarTimer.Start();
        }

        private void iconButton27_Click(object sender, EventArgs e)
        {
            PanelName = loanPanel;
            sidebarTimer.Start();
        }

        private void iconButton21_Click(object sender, EventArgs e)
        {
            PanelName = mandatoryPanel;
            sidebarTimer.Start();
        }

        private void iconButton29_Click(object sender, EventArgs e)
        {
            PanelName = securityPanel;
            sidebarTimer.Start();
        }

        private void iconButton33_Click(object sender, EventArgs e)
        {
            PanelName = reportsPanel;
            sidebarTimer.Start();
        }

        private void iconButton44_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton45_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCompanySetup_Click(object sender, EventArgs e)
        {
            new ClsOpenForms(new frmCompanySetup());
        }

        private void btnLoanSubtitle_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Company Loan Subtitle");
            showContent(new frmLoanSubtitle());
        }

        private void btnDesignation_Click(object sender, EventArgs e)
        {
            showContent(new frmDesignation());
        }

        private void btnJobCat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Company Job Category");
        }



        private void showContent(UserControl frmName)
        {
            contentPanel.Controls.Clear();
            frmName.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(frmName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showContent(new frmDashboard());
        }
    }

}
