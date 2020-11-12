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
        private static SqlConnection conn;
        public static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }
        private CategoryDAO()
        {
            conn = sqlConnection.getConnection();
        }
        public List<string> getAllCategoryName()
        {
            List<string> CategoryListName = new List<string>();
            string Sql = "SELECT CategoryName FROM dbo.Category";
            SqlCommand cmd = new SqlCommand(Sql, conn);
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        CategoryListName.Add(dataReader.GetString(0));
                    }
                }                
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return CategoryListName;
        }
        public int getCategoryID(string CategoryName)
        {
            int CategoryID = -1;
            if (CategoryName != null)
            {
                string Sql = "SELECT CategoryID FROM dbo.Category WHERE CategoryName = @CategoryName";
                SqlCommand cmd = new SqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        CategoryID = dataReader.GetInt32(0);
                    }
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return CategoryID;
        }
        public string getCategoryName(int CategoryID)
        {
            string CategoryName = null;
            string Sql = "SELECT CategoryName FROM dbo.Category WHERE CategoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(Sql, conn);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    CategoryName = dataReader.GetString(0);
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return CategoryName;
        }
    }
}
