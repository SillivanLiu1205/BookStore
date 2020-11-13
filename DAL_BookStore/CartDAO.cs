using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BookStore
{
    public class CartDAO
    {
        private static SqlConnection Conn;
        public static CartDAO _Instance;
        public static CartDAO Instance
        {
            get { if (_Instance == null) _Instance = new CartDAO(); return _Instance; }
            private set { _Instance = value; }
        }
        private CartDAO()
        {
            Conn = MySqlConnection.GetConnection();
        }

        /*public List<Cart> GetAllCartByUserame (string Username)
        {
            List<Cart> CartList = new List<Cart>();
            Account account = AccountDAO.Instance.FindAccountByUsername(Username);
            string Sql = "SELECT * FROM dbo.Cart WHERE Username = @Username";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@Username", Username);
            try
            {
                if(Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlDataReader DataReader = Cmd.ExecuteReader();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        int CartID = DataReader.GetInt32(0);
                        DateTime OrderDate = DataReader.GetDateTime(1);
                        DateTime ReceiveDate = DataReader.GetDateTime(2);
                        string Status = DataReader.GetString(4);
                        CartList.Add(new Cart(CartID, OrderDate, ReceiveDate, Status, account));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return CartList;
        }*/

        /*public List<Cart> GetAllCartByDateMothYear (DateTime Date, string SearchBy)
        {
            List<Cart> CartList = new List<Cart>();
            Account account = null;
            string Sql;
            if (SearchBy.Equals("Date"))
            {
                Sql = "SELECT * FROM dbo.Cart WHERE DateReceive = @Date";
            }
            else if (SearchBy.Equals("Month"))
            {
                Sql = "SELECT * FROM dbo.Cart WHERE MONTH(DateReceive) = MONTH(@Date) AND YEAR(DateReceive) = YEAR(@Date)";
            }
            else
            {
                Sql = "SELECT * FROM dbo.Cart WHERE YEAR(DateReceive) = YEAR(@Date)";
            }
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@Date", Date);
            try
            {
                if(Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlDataReader DataReader = Cmd.ExecuteReader();
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        int CartID = DataReader.GetInt32(0);
                        DateTime OrderDate = DataReader.GetDateTime(1);
                        string Username = DataReader.GetString(3);
                        string Status = DataReader.GetString(4);
                        if(account == null)
                        {
                            account = AccountDAO.Instance.FindAccountByUsername(Username);
                        }
                        CartList.Add(new Cart(CartID, OrderDate, Date, Status, account));
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
            return CartList;
        }
        public Cart FindCartByCartID(int CartID)
        {
            Cart cart = null;
            string Sql = "SELECT * FROM dbo.Cart WHERE CartID = @CartID";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@CartID", CartID);
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlDataReader DataReader = Cmd.ExecuteReader();
                if (DataReader.HasRows)
                {
                    DataReader.Read();
                    DateTime OrderDate = DataReader.GetDateTime(1);
                    DateTime ReceiveDate = DataReader.GetDateTime(2);
                    string Username = DataReader.GetString(3);
                    string Status = DataReader.GetString(4);
                    cart = new Cart(CartID, OrderDate, ReceiveDate, Status, AccountDAO.Instance.FindAccountByUsername(Username));
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Conn.Open();
            }
            return cart;
        }

        public bool AddCartByUsername(Cart cart)
        {
            bool Result = false;
            string Sql = "INSERT INTO dbo.Cart VALUES(@OrderDate, NULL, @Username, 'doing')";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@OderDate", cart.DateOrder);
            Cmd.Parameters.AddWithValue("@Username", cart.CartAccount.Username);
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
        }*/

    }
}
