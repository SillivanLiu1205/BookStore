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
        private static SqlConnection Conn;
        public static AccountDAO _Instance;
        public static AccountDAO Instance
        {
            get { if (_Instance == null) _Instance = new AccountDAO(); return _Instance; }
            private set { _Instance = value; }
        }
        private AccountDAO()
        {
            Conn = MySqlConnection.GetConnection();
        }

        public DataTable GetAccounts()
        {
            string Sql = "SELECT * FROM dbo.Account";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            try
            {
                if(Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                Da.Fill(Dt);                
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Dt;
        }
        public Account CheckLogin(string Username, string Password)
        {
            Account Account = null;
            string Sql = "SELECT * FROM dbo.Account WHERE Username = @Username AND Password = @Password";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@Username", Username);
            Cmd.Parameters.AddWithValue("@Password", Password);
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlDataReader Reader = Cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        string Fullname = Reader.GetString(1);
                        string Role = Reader.GetString(3);
                        string Address = Reader.GetString(4);
                        string Phone = Reader.GetString(5);
                        Account = new Account(Username, Fullname, Password, Role, Address, Phone);
                    }
                }                
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Account;
        }
        public bool AddNewAccount(Account NewAccount)
        {
            bool Result = false;
            string SQL = "INSERT INTO dbo.Account VALUES(@Username, @Fullname,@Password, @Role, @Address, @Phone)";
            SqlCommand Cmd = new SqlCommand(SQL, Conn);
            Cmd.Parameters.AddWithValue("@Username", NewAccount.Username);
            Cmd.Parameters.AddWithValue("@Fullname", NewAccount.Fullname);
            Cmd.Parameters.AddWithValue("@Password", NewAccount.Password);
            Cmd.Parameters.AddWithValue("@Role", NewAccount.Role);
            Cmd.Parameters.AddWithValue("@Address", NewAccount.Address);
            Cmd.Parameters.AddWithValue("@Phone", NewAccount.Phone);            
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                Result = Cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Result;
        }
        public bool UpdateAccount(Account NewAccount)
        {
            bool Result = false;
            string Sql = "UPDATE dbo.Account SET " +
                         "FullName = @Fullname, " +
                         "Password = @Password, " +
                         "Address = @Address, " +
                         "Phone = @Phone " +
                         "WHERE Username = @Username";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@Fullname", NewAccount.Fullname);
            Cmd.Parameters.AddWithValue("@Password", NewAccount.Password);
            Cmd.Parameters.AddWithValue("@Address", NewAccount.Address);
            Cmd.Parameters.AddWithValue("@Phone", NewAccount.Address);
            Cmd.Parameters.AddWithValue("@Username", NewAccount.Address);
            try
            {
                if(Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                Result = Cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Conn.Close();
            }
            return Result;
        }
        public DataTable FindAccount(string SearchBy, string SearchContext)
        {
            String Sql;
            if (SearchContext != null)
            {
                Sql = "SELECT * FROM dbo.Account";
            }
            else
            {
                Sql = "SELECT * FROM dbo.Account WHERE " + SearchBy + "like '%" + SearchContext + "%'";
            }
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                da.Fill(dt);                
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Conn.Close();
            }
            return dt;
        }

    }
}
