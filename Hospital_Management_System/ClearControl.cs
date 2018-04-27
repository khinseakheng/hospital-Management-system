using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    class ClearControl
    {
        public void ClearTextBoxes(UserControl user)
        {
            foreach (Control control in user.Controls)
            {

                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(ComboBox))
                {
                    control.Text = "";
                }

            }
        }

    }
}
