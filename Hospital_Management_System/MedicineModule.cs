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
    public partial class MedicineModule : UserControl
    {
        public int btclick = 2;
        public MedicineModule()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select MeID from tbMedicine", "MeID");
            string TID = x.ToString();
            txtMeID.Text = TID;
            btclick = 1;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btclick = 2;
            txtName.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (btclick == 1)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Insert Into tbMedicine(MeID,MeName,MeType,StockQty,MeCategoryID,Cost) " +
                                   "VALUES (" +
                                     "'" + txtMeID.Text + "'," +
                                     "'" + txtName.Text + "'," +
                                     "'" + cmbCategory.Text + "'," +
                                     "'" + txtStockqty.Text + "'," +
                                     "'" + txtCategoryID.Text + "'," +
                                     "'" + txtCost.Text + "'" +
                                     ")");
                MedicineModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);

            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbMedicine Set " +
                    " MeName='" + txtName.Text + "'," +
                    " MeType='" + cmbCategory.Text + "'," +
                    " StockQty='" + txtStockqty.Text +"'," +
                    " Cost='" + txtCost.Text + "'," +
                    " MeCategoryID='" + txtCategoryID.Text + "'" +
                    " Where MeID  ='" + txtMeID.Text + "'");
                MedicineModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
            }
        }

        private void MedicineModule_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("Select MeName from tbMedicine", "MeName", lstView);
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
           // select* from tbMedicine Inner Join tbMeCategory on tbMedicine.MeCategoryID = tbMeCategory.MeCategoryID where tbMedicine.MeID = '" + txtMeID.Text + "'"
            int x = lstView.SelectedIndex + 1;
            txtMeID.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbMedicine where MeID = '" + txtMeID.Text + "'",
                "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbMedicine");
            txtName.Text = ds.Tables["tbMedicine"].Rows[0].ItemArray[1].ToString();
            cmbCategory.Text = ds.Tables["tbMedicine"].Rows[0].ItemArray[2].ToString();
            txtStockqty.Text = ds.Tables["tbMedicine"].Rows[0].ItemArray[3].ToString();
            txtCategoryID.Text = ds.Tables["tbMedicine"].Rows[0].ItemArray[4].ToString();
            txtCost.Text = ds.Tables["tbMedicine"].Rows[0].ItemArray[5].ToString();
            
        }

        private void cmbCategory_MouseUp(object sender, MouseEventArgs e)
        {
            cmbCategory.Items.Clear();
            dbConnection dbcon = new dbConnection();
            dbcon.OpenConection();
            SqlDataReader dr = dbcon.DataReader("select Category from tbMeCategory");
            dr.Read();
            if (dr.HasRows)

            {
                cmbCategory.Items.Add(dr["Category"]).ToString();
                while (dr.Read())
                {
                    cmbCategory.Items.Add(dr["Category"]).ToString();
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategoryID.Text = (cmbCategory.SelectedIndex + 1).ToString();
        }
    }
}
