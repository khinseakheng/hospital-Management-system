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
    public partial class RoomModule : UserControl
    {
        public int btclick = 2;
        public RoomModule()
        {
            InitializeComponent();
        }

        public void RoomModule_Load(object sender, EventArgs e)
        {
            
            listViewShow lst = new listViewShow();
            lst.ShowData("select RoomNo from tbRoom", "RoomNo", lstView);
           
            dbConnection dbcon = new dbConnection();
            dbcon.OpenConection();
            SqlDataReader dr = dbcon.DataReader("select RType from tbRoomType");
            dr.Read();
            if (dr.HasRows)

            {
                cmbRType.Items.Add(dr["RType"]).ToString();
                while (dr.Read())
                {
                    cmbRType.Items.Add(dr["RType"]).ToString();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            int index = lstView.FindString(this.txtSearch.Text);
            if (0 <= index)
            {
                lstView.SelectedIndex = index;
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            ClearControl cls = new ClearControl();
            cls.ClearTextBoxes(this);
            AutoID ID = new AutoID();
            int x;
            x = ID.getID("Select RoomNo from tbRoom", "RoomNo");
            string TID = x.ToString();
            txtRoomNo.Text = TID;
            btclick = 1;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            cmbRType.Focus();
            btclick = 2;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (btclick == 1)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("INSERT INTO tbRoom(RoomNo,Availablebed,Building,Rfloor,RtypeID) " +
                                   "VALUES (" +
                                     "'" + txtRoomNo.Text + "'," +
                                     "'" + txtAvaliable.Text + "'," +
                                     "'" + cmbBuiding.Text + "'," +
                                     "'" + txtFloor.Text + "'," +
                                     "'" + cmbRoomTID.Text + "'" +                               
                                     ")");
                RoomModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);

            }
            if (btclick == 2)
            {
                dbConnection dbcon = new dbConnection();
                dbcon.OpenConection();
                dbcon.ExecuteQueries("Update tbRoom Set " +
                    " Availablebed='" + txtAvaliable.Text + "'," +
                    " Building='" + cmbBuiding.Text + "'," +
                    " Rfloor='" + txtFloor.Text + "', " +
                    " RtypeID='" + cmbRoomTID.Text + "'" +
                    " Where RoomNo  ='" + txtRoomNo.Text + "'");
                RoomModule_Load(this, null);
                ClearControl cn = new ClearControl();
                cn.ClearTextBoxes(this);
            }
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = lstView.SelectedIndex + 1;
            txtRoomNo.Text = x.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select tbRoom.RoomNo,tbRoom.Availablebed,tbRoom.Building," +
                "tbRoom.Rfloor,tbRoom.RtypeID,tbRoomType.RType,tbRoomType.NumofBed,tbRoomType.Price,tbRoomType.RTypeID" +
                " from tbRoom Inner Join tbRoomType on tbRoom.RtypeID = tbRoomType.RTypeID where tbRoom.RoomNo = '" + txtRoomNo.Text + "'",
                "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds,"tbRoom");
            txtAvaliable.Text = ds.Tables["tbRoom"].Rows[0].ItemArray[1].ToString();
            txtFloor.Text = ds.Tables["tbRoom"].Rows[0].ItemArray[3].ToString(); ;
            txtprice.Text = ds.Tables["tbRoom"].Rows[0].ItemArray[7].ToString(); ;
            txtTotalBed.Text = ds.Tables["tbRoom"].Rows[0].ItemArray[6].ToString(); ;
            cmbBuiding.Text = ds.Tables["tbRoom"].Rows[0].ItemArray[2].ToString(); ;
            cmbRoomTID.Text = ds.Tables["tbRoom"].Rows[0].ItemArray[4].ToString(); ;
            cmbRType.Text = ds.Tables["tbRoom"].Rows[0].ItemArray[5].ToString(); ;
        }

        private void cmbRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Cmb = cmbRType.SelectedIndex+1;
            cmbRoomTID.Text = Cmb.ToString();
            //txtRoomNo.Text = Cmb.ToString();
            dbConnection conn = new dbConnection();
            SqlDataAdapter dr = new SqlDataAdapter("select * from tbRoomType where RTypeID = '" + cmbRoomTID.Text + "'",
                "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30");
            DataSet ds = new DataSet();
            dr.Fill(ds, "tbRoomType");
            txtTotalBed.Text = ds.Tables["tbRoomType"].Rows[0].ItemArray[2].ToString();
            txtprice.Text = ds.Tables["tbRoomType"].Rows[0].ItemArray[3].ToString();
            if (btclick==1)
            txtAvaliable.Text = ds.Tables["tbRoomType"].Rows[0].ItemArray[2].ToString();
        }

        private void cmbRType_MouseUp(object sender, MouseEventArgs e)
        {
            cmbRType.Items.Clear();
            dbConnection dbcon = new dbConnection();
            dbcon.OpenConection();
            SqlDataReader dr = dbcon.DataReader("select RType from tbRoomType");
            dr.Read();
            if (dr.HasRows)

            {
                cmbRType.Items.Add(dr["RType"]).ToString();
                while (dr.Read())
                {
                    cmbRType.Items.Add(dr["RType"]).ToString();
                }
            }
        }

        private void cmbRType_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
