using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Dashboard_2.FldrClass
{
    class ClsOpenForms
    {
        public ClsOpenForms(Form varForm)
        {
            string varFormName = varForm.Name;
            Form Form1 = Application.OpenForms[varFormName];
            if (Form1 != null)
            {
                if (Form1.WindowState == FormWindowState.Minimized)
                {
                    Form1.WindowState = FormWindowState.Normal;
                }
                else
                {
                    Form1.BringToFront();
                }
            }
            else
            {
                varForm.Show();
            }
        }
    }
}
