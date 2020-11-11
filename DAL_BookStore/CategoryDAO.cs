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
    }
}
