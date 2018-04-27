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
    public partial class frmRoomType : Form
    {
        public frmRoomType()
        {
            InitializeComponent();
        }

        private void frmRoomType_Load(object sender, EventArgs e)
        {
            listViewShow lst = new listViewShow();
            lst.ShowData("Select RType from tbRoomType", "RType", lstRoomType);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            int x = lstRoomType.SelectedIndex + 1;
            //RoomInfo Rinfo = new RoomInfo(x.ToString());
        }
    }
}
