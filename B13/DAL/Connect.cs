using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        public SqlConnection connSQL;
        public Connect()
        {
            string connectionString = "Data Source=A206PC40;Initial Catalog=QLSV;Integrated Security=True";
            connSQL = new SqlConnection(connectionString);
            OpenConn();
        }
        public void OpenConn()
        {
            if(connSQL.State == ConnectionState.Closed)
            {
                connSQL.Open();
            }
        }
        public void CloseConn()
        {
            if (connSQL.State == ConnectionState.Open)
            {
                connSQL.Close();
            }
        }
    }
}
