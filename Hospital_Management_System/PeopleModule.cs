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
    public partial class PeopleModule : UserControl
    {
        public PeopleModule()
        {
            InitializeComponent();
        }

        private void btPateint_Click(object sender, EventArgs e)
        {
            patientModule1.BringToFront();
        }

        private void btDoctor_Click(object sender, EventArgs e)
        {
            doctorModule1.BringToFront();
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            supplierModule1.BringToFront();
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            staffModule1.BringToFront();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            userModule1.BringToFront();
        }
    }
}
