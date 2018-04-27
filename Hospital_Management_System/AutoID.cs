using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Hospital_Management_System
{
    class AutoID
    {
        public int getID(string Selectstatment, string ColumName)
        {
            dbConnection dbcon = new dbConnection();
            dbcon.OpenConection();
            SqlDataReader dr = dbcon.DataReader(Selectstatment);
            dr.Read();
            string ID = null;
            
            if (dr.HasRows)
            {
                ID = dr[ColumName].ToString();
                if (ID == null)
                {
                    int y = 1;
                    return y;
                }

                while (dr.Read())
                {
                    ID = dr[ColumName].ToString();
                   
                    }
                if (ID == null)
                {
                    int y = 2;
                    return y;
                }
                if (ID != null)
                {
                    int y = Int32.Parse(ID) + 1;
                    return y;

                }
            }

            return 1;
        }
    }
}
