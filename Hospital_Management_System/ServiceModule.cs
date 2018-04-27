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
    public partial class ServiceModule : UserControl
    { 
        public int btclick=2;
        public ServiceModule()
        {
            InitializeComponent();
        }

        private void ServiceModule_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("select ServiceName from tbServices", "ServiceName", lstView);
        }

        private void btNew_Click(object sender, EventArgs e)
        {

        }

        private void btNew_Click_1(object sender, EventArgs e)
        {
            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select ServiceID from tbServices", "ServiceID");
            string TID = x.ToString();
            txtServiceID.Text = TID;
            btclick = 1;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (btclick == 1)
            {


                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("INSERT INTO tbServices" +
                    "(ServiceID,ServiceName,cost,Info) VALUES " +
                    "('" + txtServiceID.Text + "'," +
                    "'" + txtName.Text + "'," +
                    "'" + txtCost.Text + "'," +
                    "'" + txtInfo.Text + "'" +
                    ")");
                ServiceModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbServices Set " +
                    " ServiceName='" + txtName.Text + "'," +
                    " cost='" + txtCost.Text + "'," +
                    " Info='" + txtInfo.Text + "'" +
                    " Where ServiceID ='" + txtServiceID.Text + "'");
                ServiceModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btclick = 2;
            txtName.Focus();
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = lstView.SelectedIndex + 1;
            txtServiceID.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbServices where ServiceID= '" + txtServiceID.Text + "'", "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbServices");
            txtName.Text = ds.Tables["tbServices"].Rows[0].ItemArray[1].ToString();
            txtCost.Text = ds.Tables["tbServices"].Rows[0].ItemArray[2].ToString();
            txtInfo.Text = ds.Tables["tbServices"].Rows[0].ItemArray[3].ToString();
        }
    }
}
