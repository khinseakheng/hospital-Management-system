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
    public partial class PatientModule : UserControl
    {
        public int btclick = 2;
        public PatientModule()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {

            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select PID from tbPatient", "PID");
            string TID = x.ToString();
            txtID.Text = TID;
            btSave.Enabled = true;
            txtName.Focus();
            btclick = 1;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (btclick == 1)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("INSERT INTO tbPatient" +
                    "(PID,PName,Gender,PType,Nation,Birhtdate,PAddress,Phone,illstatus,BloodType,Occupation) VALUES " +
                    "('" + txtID.Text + "'," +
                    "'" + txtName.Text + "'," +
                    "'" + cmbSex.Text + "'," +
                    "'" + cmbType.Text + "'," +
                    "'" + txtNation.Text + "'," +
                    "'" + txtBD.Text + "'," +
                    "'" + txtAddress.Text + "'," +
                    "'" + txtPhone.Text + "'," +
                    "'" + txtIllStatus.Text + "'," +
                    "'" + cmbBtype.Text + "'," +
                    "'" + txtOccupation.Text + "'" +
                    ")");
                if (cmbType.Text == "Inpatient ")
                {
                    MessageBox.Show("go to checkin");
                }
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);

            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbPatient Set " +
                    " PID='" + txtID.Text + "', " +
                    " PName='" + txtName.Text + "'," +
                    " Gender='" + cmbSex.Text + "'," +
                    " PType='" + cmbType.Text + "', " +
                    " Nation='" + txtNation.Text + "', " +
                    " Birhtdate='" + txtBD.Text + "', " +
                    " PAddress='" + txtAddress.Text + "', " +
                    " Phone='" + txtPhone.Text + "', " +
                    " illstatus='" + txtIllStatus.Text + "', " +
                    " BloodType='" + cmbBtype.Text + "', " +
                    " Occupation='" + txtOccupation.Text + "'" +
                    " Where PID ='" + txtID.Text + "'");
                
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select PName from tbPatient", "PName", lstView);
            }


        }

        private void PatientModule_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("Select PName from tbPatient", "PName", lstView);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btclick = 2;
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = lstView.SelectedIndex + 1;
            txtID.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbPatient where PID= '" + txtID.Text + "'", "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbPatient");
            txtName.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[1].ToString();
            cmbSex.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[2].ToString();
            cmbType.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[3].ToString();
            txtNation.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[4].ToString();
            txtBD.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[5].ToString();
            txtAddress.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[6].ToString();
            txtPhone.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[7].ToString();
            txtIllStatus.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[8].ToString();
            cmbBtype.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[9].ToString();
            txtOccupation.Text = ds.Tables["tbPatient"].Rows[0].ItemArray[10].ToString();


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
