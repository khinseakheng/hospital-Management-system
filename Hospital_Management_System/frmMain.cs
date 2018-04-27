using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            Clear cls = new Clear();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select PID from tbPatient", "PID");
            string TID = x.ToString();
            txtID.Text = TID;
            btSave.Enabled = true;
            txtName.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
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
            Clear cn = new Clear();
            cn.ClearTextBoxes(this);
        }

        private void btPeople_Click(object sender, EventArgs e)
        {
            peopleModule1.Show();
            peopleModule1.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            peopleModule1.Hide();
            masterEntry1.Hide();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            peopleModule1.Hide();
            masterEntry1.Hide();
        }

        private void peopleModule1_Load(object sender, EventArgs e)
        {

        }

        private void btMasrerEntry_Click(object sender, EventArgs e)
        {
            masterEntry1.Show();
            masterEntry1.BringToFront();
        }
    }
}
