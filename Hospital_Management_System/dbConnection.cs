using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public class dbConnection
    {

        string ConnectionString = "Database=DBHospital;Server=SEAKHENG\\KSH;Integrated Security=True;connect timeout = 30";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();

        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public void DataAdapter(string Query_,DataGridView dtv)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataTable ds = new DataTable();
            dr.Fill(ds);
            dtv.DataSource = ds;
            
            //object dataum = ds.Tables[0];
            //return dataum;
        }


    }
}
