using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    class listViewShow
    {
        public void ShowData(String SelectStatment, String ColumnName, ListBox listView)
        {
            listView.Items.Clear();
            dbConnection dbcon = new dbConnection();
            dbcon.OpenConection();
            SqlDataReader dr = dbcon.DataReader(SelectStatment);
            while (dr.Read())
            {
                listView.Items.Add(dr[ColumnName]);
            }
        }
        public void ListData(String SelectStatment, String ColumnName1, String ColumnName2, ListView listView)
        {
            listView.Items.Clear();
            dbConnection dbcon = new dbConnection();
            dbcon.OpenConection();
            SqlDataReader dr = dbcon.DataReader(SelectStatment);
            while (dr.Read())
            {
                listView.Items.Add(dr[ColumnName1].ToString());
                listView.Items.Add(dr[ColumnName2].ToString());
            }
        }
    }
}
