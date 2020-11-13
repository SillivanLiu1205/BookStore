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
    public class CartDetailDAO
    {
        private static SqlConnection Conn;
        public static CartDetailDAO _Instance;
        public static CartDetailDAO Instance
        {
            get { if (_Instance == null) _Instance = new CartDetailDAO(); return _Instance; }
            private set { _Instance = value; }
        }

        public List<CartDetail> GetCartDetailByCartID(int CartID)
        {
            List<CartDetail> DetailList = new List<CartDetail>();
            Cart cart = CartDAO.Instance.FindCartByCartID(CartID);
            string Sql = "SELECT * FROM dbo.CartDetail WHERE CartID = @CartID";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@CartID", CartID);
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
                        int CartDetailID = DataReader.GetInt32(0);
                        int BookID = DataReader.GetInt32(2);
                        int Quantity = DataReader.GetInt32(3);
                        DetailList.Add(new CartDetail(CartDetailID, Quantity, cart, BookDAO.Instance.FindBookByID(BookID)));
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
            return DetailList;
        }
        public bool DeleteCartDetail(int CartDetailID)
        {
            bool Result = false;
            string Sql = "DELETE FROM dbo.CartDeatail WHERE CartDeatailID = @CartDEATILid";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@CartDetailID", CartDetailID);
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
        public bool AddNewCartDeailt(CartDetail cartDetail)
        {
            bool Result = false;
            string Sql = "INSERT INTO dbo.CartDetail VALUES(@CartDetailID, @CartID, @BookID, @Quantity)";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@CartDetailID", cartDetail.CartDetailID);
            Cmd.Parameters.AddWithValue("@CartID", cartDetail.CartDetailCart.CartID);
            Cmd.Parameters.AddWithValue("@BookID", cartDetail.CartDetailBook.BookID);
            Cmd.Parameters.AddWithValue("@Quantity", cartDetail.Quantity);
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
        public bool UpdateCartDetailQuantity(int CartDetailID, int NewQuantity)
        {
            bool Result = false;
            string SQL = "UPDATE Books SET Quantity = @Quantity WHERE CartDetailID = @CartDetailID";
            SqlCommand Cmd = new SqlCommand(SQL, Conn);
            Cmd.Parameters.AddWithValue("@Quantity", NewQuantity);
            Cmd.Parameters.AddWithValue("@CartDetailID", CartDetailID);            
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
    }
}
