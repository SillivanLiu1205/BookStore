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
        public static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO()
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
        public Account checkLogin(string Username, string Password)
        {
            Account account = null;
            string Sql = "SELECT * FROM dbo.Account WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(Sql, conn);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    account = new Account();
                    while (reader.Read())
                    {
                        account.Username = reader.GetString(0);
                        account.Fullname = reader.GetString(1);
                        account.Password = reader.GetString(2);
                        account.Role = reader.GetString(3);
                        account.Address = reader.GetString(4);
                        account.Phone = reader.GetString(5);
                    }
                }
            }
            return account;
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
        
    }
}
