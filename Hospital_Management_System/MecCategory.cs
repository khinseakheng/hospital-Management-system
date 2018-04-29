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
        public int btclick = 2;
        public MecCategory()
        {
            InitializeComponent();
        }

        private void MecCategory_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("select Category from tbMecategory", "Category", lstView);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select MeID from tbMedicine", "MeID");
            string TID = x.ToString();
            txtcategoryID.Text = TID;
            btclick = 1;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btclick = 2;
            txtCategoryName.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}
