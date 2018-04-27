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
    public partial class StaffModule : UserControl
    {
        public int btclick = 2;
        public StaffModule()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {

            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select StaffID from tbStaff", "StaffID");
            string TID = x.ToString();
            txtStaffID.Text = TID;
            btclick = 1;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            btclick = 2;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (btclick == 1)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("INSERT INTO tbStaff (staffID, Staffname, Gender,Birthdate,Position,salary,Phone,Email,SAddress,Hireddate,Stopwork) " +
                                   "VALUES (" +
                                     "'" + txtStaffID.Text + "'," +
                                     "'" + txtName.Text + "'," +
                                     "'" + cmbSex.Text + "'," +
                                     "'" + txtBD.Text + "'," +
                                     "'" + cmbPosition.Text + "'," +
                                     "'" + txtSalary.Text + "'," +
                                     "'" + txtphone.Text + "'," +
                                     "'" + txtEmail.Text + "'," +
                                     "'" + txtAddress.Text + "'," +
                                     "'" + txtHD.Text + "'," +

                                     "'" + cmbStopWork.Text + "'" +
                                     ")");
                StaffModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select StaffName from tbStaff", "StaffName", lstView);

            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbStaff Set " +
                    " staffID='" + txtStaffID.Text + "', " +
                    " Staffname='" + txtName.Text + "'," +
                    " Gender='" + cmbSex.Text + "'," +
                    " Birthdate='" + txtBD.Text + "', " +
                    " Position='" + cmbPosition.Text + "', " +
                    " salary='" + txtSalary.Text + "', " +
                    " Email='" + txtEmail.Text + "', " +
                    " SAddress='" + txtAddress.Text + "', " +
                    " Phone='" + txtphone.Text + "', " +
                    " Hireddate='" + txtHD.Text + "', " +
                    " Stopwork='" + cmbStopWork.Text + "'" +
                    " Where StaffID ='" + txtStaffID.Text + "'");
                StaffModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select StaffName from tbStaff", "StaffName", lstView);

            }
        }

        private void StaffModule_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("select StaffName from tbStaff", "StaffName", lstView);
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = lstView.SelectedIndex + 1;
            txtStaffID.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbStaff where StaffID= '" + txtStaffID.Text + "'", "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbStaff");
            txtName.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[1].ToString();
            cmbSex.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[2].ToString();
            cmbPosition.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[4].ToString();
            txtAddress.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[8].ToString();
            txtphone.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[6].ToString();
            txtEmail.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[7].ToString();
            txtSalary.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[5].ToString();
            txtBD.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[3].ToString();
            txtHD.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[9].ToString();
            cmbStopWork.Text = ds.Tables["tbStaff"].Rows[0].ItemArray[11].ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int index = lstView.FindString(this.txtSearch.Text);
            if (0 <= index)
            {
                lstView.SelectedIndex = index;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbStopWork_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
