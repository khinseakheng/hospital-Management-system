using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class SupplierModule : UserControl
    {
        public int btclick = 2;
        public SupplierModule()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select SupplierID from tbSupplier", "SupplierID");
            string TID = x.ToString();
            txtSupplierID.Text = TID;
            btclick = 1;
            btSave.Enabled = true;
            btEdit.Enabled = false;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btclick = 2;
            txtName.Focus();
            btSave.Enabled = false;
            btSave.Enabled = true;
            btNew.Enabled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (btclick == 1)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("INSERT INTO tbSupplier (SupplierID, SupplierName, SupplierPhone,country) " +
                                     "VALUES ('" + txtSupplierID.Text + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtAdress.Text + "')");
                SupplierModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select SupplierName from tbSupplier", "SupplierName", lstView);
                btNew_Click(this, null);
            }
            if (btclick == 2)
            {

                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbSupplier Set SupplierID='" + txtSupplierID.Text + "', SupplierName='" + txtName.Text + "', SupplierPhone='" + txtPhone.Text + "', Country='" + txtAdress.Text + "' Where SupplierID='" + txtSupplierID.Text + "'");
                SupplierModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select SupplierName from tbSupplier", "SupplierName", lstView);
                btNew_Click(this, null);
                MessageBox.Show("Record was Updated!!");

            }
            btSave.Enabled = false;
        }

        private void SupplierModule_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("select SupplierName from tbSupplier", "SupplierName", lstView);
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = lstView.SelectedIndex + 1;
            txtSupplierID.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbSupplier where SupplierID= '" + txtSupplierID.Text + "'", "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbSupplier");
            txtName.Text = ds.Tables["tbSupplier"].Rows[0].ItemArray[1].ToString();
            txtPhone.Text = ds.Tables["tbSupplier"].Rows[0].ItemArray[2].ToString();
            // txtMail.Text = ds.Tables["tbSupplier"].Rows[0].ItemArray[3].ToString();
            txtAdress.Text = ds.Tables["tbSupplier"].Rows[0].ItemArray[3].ToString();
            btSave.Enabled = false;
            btEdit.Enabled = true;
            btNew.Enabled = true;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int index = lstView.FindString(this.txtSearch.Text);
            if (0 <= index)
            {
                lstView.SelectedIndex = index;
            }
        }
    }
}
