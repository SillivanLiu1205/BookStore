using DTO_BookStore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BookStore
{
    public class AccountDAO
    {
        private static SqlConnection conn;
        public AccountDAO()
        {
            conn = sqlConnection.getConnection();
        }

        public DataTable getAccounts()
        {
            string Sql = "SELECT * FROM dbo.Account";
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool AddNewAccount(Account account)
        {
            bool result;
            string SQL = "INSERT INTO dbo.Account VALUES(@Username, @Fullname,@Password, @Role, @Address, @Phone)";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Username", account.Username);
            cmd.Parameters.AddWithValue("@Fullname", account.Fullname);
            cmd.Parameters.AddWithValue("@Password", account.Password);
            cmd.Parameters.AddWithValue("@Role", account.Role);
            cmd.Parameters.AddWithValue("@Address", account.Address);
            cmd.Parameters.AddWithValue("@Phone", account.Phone);            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return result;
        }

        public bool UpdateAccount(Account account)
        {
            bool result;
            string sql = "UPDATE Books SET @Username, @Fullname, @Password, @Role, @"
            return result;
        }
    }
}
