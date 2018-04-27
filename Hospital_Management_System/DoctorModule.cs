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
    public partial class DoctorModule : UserControl
    {
        public int btclick = 2;
        public DoctorModule()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select docID from tbDoctor", "docID");
            string TID = x.ToString();
            txtDoctorID.Text = TID;
            btclick = 1;
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = lstView.SelectedIndex + 1;
            txtDoctorID.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbDoctor where DocID= '" + txtDoctorID.Text + "'", "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbDoctor");
            txtName.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[1].ToString();
            cmbSex.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[2].ToString();
            txtBD.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[3].ToString();
            txtEmail.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[4].ToString();
            txtSkill.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[5].ToString();
            txtNation.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[6].ToString();
            txtDegree.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[7].ToString();
            txtSalary.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[8].ToString();
            txtPhone.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[9].ToString();
            txtEmail.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[10].ToString();
            txtContractdate.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[11].ToString();
            txtExpireDate.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[12].ToString();
            cmbStopWork.Text = ds.Tables["tbDoctor"].Rows[0].ItemArray[13].ToString();
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
                dbcon.ExecuteQueries("INSERT INTO tbDoctor" +
                    "(DocID, Docname, Gender, Birthdate, DAddress, Specialize,Nation,Degree,salary," +
                    "Phone,Email,Contractdate,ExpiredDate,Stopwork) VALUES " +
                    "('" + txtDoctorID.Text + "','" + txtName.Text + "'," +
                    "'" + cmbSex.Text + "','" + txtBD.Text + "','" + txtEmail.Text + "'," +
                    "'" + txtSkill.Text + "','" + txtNation.Text + "','" + txtDegree.Text + "'," +
                    "'" + txtSalary.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "'," +
                    "'" + txtContractdate.Text + "','" + txtExpireDate.Text + "','" + cmbStopWork.Text + "')");
                DoctorModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select docname from tbDoctor", "docname", lstView);
                btNew_Click(this, null);
            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbDoctor Set " +
                    " DocID='" + txtDoctorID.Text + "', " +
                    " Docname='" + txtName.Text + "'," +
                    " Gender='" + cmbSex.Text + "'," +
                    " Birthdate='" + txtBD.Text + "', " +
                    " DAddress='" + txtEmail.Text + "', " +
                    " Specialize='" + txtSkill.Text + "', " +
                    " Nation='" + txtNation.Text + "', " +
                    " Degree='" + txtDegree.Text + "', " +
                    " salary='" + txtSalary.Text + "', " +
                    " Phone='" + txtPhone.Text + "', " +
                    " Email='" + txtEmail.Text + "', " +
                    " Contractdate='" + txtContractdate.Text + "', " +
                    " ExpiredDate='" + txtExpireDate.Text + "', " +
                    " Stopwork='" + cmbStopWork.Text + "'" +
                    " Where DocID ='" + txtDoctorID.Text + "'");
                DoctorModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                listViewShow lst = new listViewShow();
                lst.ShowData("Select docname from tbDoctor", "docname", lstView);
            }
        }

        private void DoctorModule_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("Select Docname from tbDoctor", "Docname", lstView);
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
