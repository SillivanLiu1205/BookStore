using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BookStore
{
    public class CategoryDAO
    {
        private static SqlConnection Conn;
        public static CategoryDAO _Instance;
        public static CategoryDAO Instance
        {
            get { if (_Instance == null) _Instance = new CategoryDAO(); return _Instance; }
            private set { _Instance = value; }
        }
        private CategoryDAO()
        {
            Conn = MySqlConnection.GetConnection();
        }
        public List<string> GetAllCategoryName()
        {
            List<string> CategoryListName = new List<string>();
            string Sql = "SELECT CategoryName FROM dbo.Category";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
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
                        CategoryListName.Add(DataReader.GetString(0));
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
            return CategoryListName;
        }
        public Category GetCategoryByName(string CategoryName)
        {
            Category category = null;
            if (CategoryName != null)
            {
                string Sql = "SELECT CategoryID FROM dbo.Category WHERE CategoryName = @CategoryName";
                SqlCommand Cmd = new SqlCommand(Sql, Conn);
                Cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
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
                        int CategoryID = DataReader.GetInt32(0);
                        category = new Category(CategoryID, CategoryName);
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
            }
            return category;
        }
        public Category GetCategoryByID(int CategoryID)
        {
            Category category = null;
            string Sql = "SELECT CategoryName FROM dbo.Category WHERE CategoryID = @CategoryID";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
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
                    string CategoryName = DataReader.GetString(0);
                    category = new Category(CategoryID, CategoryName);
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
            return category;
        }
    }
}
