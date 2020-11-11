using DTO_BookStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BookStore
{
    public class BookDAO
    {
        private static SqlConnection conn;
        public static BookDAO instance;
        public static BookDAO Instance
        {
            get { if (instance == null) instance = new BookDAO(); return instance; }
            private set { instance = value; }
        }

        private BookDAO()
        {
            conn = sqlConnection.getConnection();
        }
        public bool AddNewBook(Book book)
        {
            bool result;
            string SQL = "INSERT INTO Book VALUES(@ID, @Title,@Price, @Quantity, @Author, @Publisher, @CategoryID, @IsLocal, @Image)";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ID", book.BookID);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Price", book.Price);
            cmd.Parameters.AddWithValue("@Quantity", book.Quantity);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@Pulisher", book.Publisher);
            cmd.Parameters.AddWithValue("@CategoryID", book.Category);
            cmd.Parameters.AddWithValue("@IsLocal", book.IsLocalBook);
            cmd.Parameters.AddWithValue("@Image", book.Image);
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

        //Update Book
        public bool UpdateBook(Book book)
        {
            bool result;
            string SQL = "UPDATE Books SET @ID, @Title,@Price, @Quantity, @Author, @Publisher, @CategoryID, @IsLocal, @Image";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ID", book.BookID);
            cmd.Parameters.AddWithValue("@Title", book.Title);
            cmd.Parameters.AddWithValue("@Price", book.Price);
            cmd.Parameters.AddWithValue("@Quantity", book.Quantity);
            cmd.Parameters.AddWithValue("@Author", book.Author);
            cmd.Parameters.AddWithValue("@Pulisher", book.Publisher);
            cmd.Parameters.AddWithValue("@CategoryID", book.Category);
            cmd.Parameters.AddWithValue("@IsLocal", book.IsLocalBook);
            cmd.Parameters.AddWithValue("@Image", book.Image);
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

        //Delete Book
        public bool DeleteBook(int BookID)
        {
            bool result;
            string SQL = "DELETE FROM Book WHERE BookID = @ID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ID", BookID);
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

        public List<Book> GetBooks(string SearchBy, string SearchContext, string language, int CategoryID)
        {
            List<Book> BookList = new List<Book>();
            string Sql = "SELECT * FROM dbo.Book WHERE ";
            if (!SearchContext.Equals(string.Empty))
            {
                Sql += SearchBy + " like %@SearchContext% AND";
            }

            if (language.Equals("Vietnamese"))
            {
                Sql += "IsLocal = 1 AND";
            }
            else if (language.Equals("English"))
            {
                Sql += "IsLocal = 0 AND";
            }

            if (CategoryID != null)
            {
                Sql += "CategoryID = @CategoryID AND";
            }
            Sql += "TRUE";
            SqlCommand cmd = new SqlCommand(Sql, conn);
            cmd.Parameters.AddWithValue("@SearchContext", SearchContext);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
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
                        Book b = new Book(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetInt32(7), dataReader.GetBoolean(8), dataReader.GetString(9));
                        BookList.Add(b);
                    }
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
            return BookList;
        }
    }
}
