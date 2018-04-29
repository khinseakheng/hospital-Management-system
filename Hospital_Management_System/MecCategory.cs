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
    public partial class MecCategory : UserControl
    {
        public MecCategory()
        {
            InitializeComponent();
        }

        private void MecCategory_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("select Category from tbMecategory", "Category", lstView);
        }
    }
}
