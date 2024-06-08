using LIS.FldrCustomToolkit;
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
    public partial class frmDashboard : UserControl
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
            for (int x = 1; x < 100; x++)
            {
                dgv1.Rows.Add("123333", "User 1", 19, "Purok Malinong, Brgy. Binicuilm Kabankalan City", "09090909099", "Single");
                dgv1.Rows.Add("333", "User 2", 11, "Purok Malinong, Brgy. Binicuilm Kabankalan City", "09090909099", "Single");
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Texts == "")
            {
                txtSearch.Texts = "Search ....";
                txtSearch.ForeColor = Color.FromArgb(114, 117, 126);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Texts == "Search ....")
            {
                txtSearch.Texts = string.Empty;
                txtSearch.ForeColor = Color.FromArgb(22, 22, 26);
            }
        }
    }
}
