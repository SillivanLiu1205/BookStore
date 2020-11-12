using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BookStore
{
    public class MySqlConnection
    {
        private static string ConnectionStr = "server=.;database=MyBookStore;uid=sa;pwd=123456";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionStr);
            return conn;
        }
    }
}
