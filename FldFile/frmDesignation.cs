using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Dashboard_2.FldFile
{
    public partial class frmDesignation : UserControl
    {
        public frmDesignation()
        {
            InitializeComponent();
        }

        private void customTextbox3_Enter(object sender, EventArgs e)
        {
            if (customTextbox3.Texts == "Search ....")
            {
                customTextbox3.Texts = string.Empty;
                customTextbox3.ForeColor = Color.FromArgb(22, 22, 26);
            }
        }

        private void customTextbox3_Leave(object sender, EventArgs e)
        {
            if (customTextbox3.Texts == "")
            {
                customTextbox3.Texts = "Search ....";
                customTextbox3.ForeColor = Color.FromArgb(114, 117, 126);
            }
        }
    }
}
