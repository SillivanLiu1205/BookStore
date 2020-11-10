using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BookStore
{
    class sqlConnection
    {
        private static string strConnection = "server=.;database=MyBookStore;uid=sa;pwd=123456";
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(strConnection);
            return conn;
        }
    }
}
