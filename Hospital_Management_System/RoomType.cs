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
    public partial class RoomType : UserControl
    {
        public int btclick = 2;
        public RoomType()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select RTypeID from tbRoomType", "RTypeID");
            string TID = x.ToString();
            txtRTID.Text = TID;
            btclick = 1;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btclick = 2;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (btclick == 1)
            {

                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("INSERT INTO tbRoomType" +
                    "(RTypeID,RType,NumofBed,Price) VALUES " +
                    "('" + txtRTID.Text + "'," +
                    "'" + cmbType.Text + "'," +
                    "'" + txtNumofBed.Text + "'," +
                    "'" + txtPrice.Text + "'" +
                    ")");
                RoomType_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbRoomType Set " +
                    " RType='" + cmbType.Text + "'," +
                    " NumofBed='" + txtNumofBed.Text + "'," +
                    " Price='" + txtPrice.Text + "'" +
                    " Where RTypeID ='" + txtRTID.Text + "'");
                RoomType_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
                
            }

        }

        private void RoomType_Load(object sender, EventArgs e)
        {
            dbConnection dbcon = new dbConnection();
            dbcon.DataAdapter("select * from tbRoomType", dataView);


        }

       

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
                txtRTID.Text = dataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNumofBed.Text = dataView.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbType.Text = dataView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = dataView.Rows[e.RowIndex].Cells[3].Value.ToString();     
        }

        private void dataView_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
