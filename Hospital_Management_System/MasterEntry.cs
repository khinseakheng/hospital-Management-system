using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class MasterEntry : UserControl
    {
        public MasterEntry()
        {
            InitializeComponent();
        }

        private void btRoom_Click(object sender, EventArgs e)
        {
            roomModule1.Refresh();
            roomModule1.BringToFront();
        }

        private void btRoomType_Click(object sender, EventArgs e)
        {
            roomType1.BringToFront();
        }

        private void btService_Click(object sender, EventArgs e)
        {
            serviceModule1.BringToFront();
        }

        private void btMedecine_Click(object sender, EventArgs e)
        {
            medicineModule1.BringToFront();
        }

        private void btMeCategory_Click(object sender, EventArgs e)
        {
            mecCategory1.BringToFront();
        }
    }
}
