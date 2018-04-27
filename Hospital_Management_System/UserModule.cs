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
    public partial class UserModule : UserControl
    {
        public int btclick = 2;
        public UserModule()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {

            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select UserID from tbUser", "UserID");
            string TID = x.ToString();
            txtUserID.Text = TID;
            btclick = 1;
            btSave.Enabled = true;
            btEdit.Enabled = false;
        }

        private void UserModule_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("Select UserName from tbUser", "UserName", lstView);
            btSave.Enabled = false;
            btNew.Enabled = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btclick = 2;
            btSave.Enabled = true;
            btNew.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int index = lstView.FindString(this.txtSearch.Text);
            if (0 <= index)
            {
                lstView.SelectedIndex = index;
            }
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {

            int x = lstView.SelectedIndex + 1;
            txtUserID.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbUser where UserID= '" + txtUserID.Text + "'", "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbUser");
            txtUserName.Text = ds.Tables["tbUser"].Rows[0].ItemArray[1].ToString();
            txtPassword.Text = ds.Tables["tbUser"].Rows[0].ItemArray[2].ToString();
            cmbAccType.Text = ds.Tables["tbUser"].Rows[0].ItemArray[3].ToString();
            txtConPass.Text = ds.Tables["tbUser"].Rows[0].ItemArray[2].ToString();
            txtRegisterDate.Text = ds.Tables["tbUser"].Rows[0].ItemArray[4].ToString();
            cmbStaff.Text = ds.Tables["tbUser"].Rows[0].ItemArray[5].ToString();
            btSave.Enabled = true;
            btEdit.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (btclick == 1)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("INSERT INTO tbUser (UserID, UserName, UserPassword, AccountType, RegisterDate, StaffID) " +
                                     "VALUES ('" + txtUserID.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','" + cmbAccType.Text + "','"
                                     + txtRegisterDate.Text + "','" + cmbStaff.Text + "')");
                UserModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select UserName from tbUser", "UserName", lstView);
                btNew_Click(this, null);
            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbUser Set UserID='" + txtUserID.Text + "', UserName='" + txtUserName.Text + "', UserPassword='" + txtPassword.Text + "', AccountType='" + cmbAccType.Text + "', RegisterDate='" + txtRegisterDate.Text + "', StaffID='" + cmbStaff.Text + "' Where UserID='" + txtUserID.Text + "'");
                UserModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select UserName from tbUser", "UserName", lstView);
            }
            btSave.Enabled = false;
            btEdit.Enabled = true;
            btNew.Enabled = true;
        }
    }
}
