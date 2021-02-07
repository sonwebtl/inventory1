using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quanlykho.DAO
{
    public class DataAccess
    {
        string strConn = "Data Source=DESKTOP-O8TFIH8\\SQLEXPRESS;Initial Catalog=quanlykho1;Integrated Security=True";
        protected SqlConnection conn = null;

        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection()
        {
            if ( (conn != null) && conn.State == (ConnectionState.Open) )
                conn.Close();
        }

    }
}
