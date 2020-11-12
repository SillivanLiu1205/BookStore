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
        private static SqlConnection Conn;
        public static BookDAO _Instance;
        public static BookDAO Instance
        {
            get { if (_Instance == null) _Instance = new BookDAO(); return _Instance; }
            private set { _Instance = value; }
        }

        private BookDAO()
        {
            Conn = MySqlConnection.GetConnection();
        }
        public bool AddNewBook(Book book)
        {
            bool Result = false;
            string SQL = "INSERT INTO dbo.Book VALUES(@ID, @Title,@Price, @Quantity, @Author, @Publisher, @CategoryID, @IsLocal, @Image)";
            SqlCommand Cmd = new SqlCommand(SQL, Conn);
            Cmd.Parameters.AddWithValue("@ID", book.BookID);
            Cmd.Parameters.AddWithValue("@Title", book.Title);
            Cmd.Parameters.AddWithValue("@Price", book.Price);
            Cmd.Parameters.AddWithValue("@Quantity", book.Quantity);
            Cmd.Parameters.AddWithValue("@Author", book.Author);
            Cmd.Parameters.AddWithValue("@Pulisher", book.Publisher);
            Cmd.Parameters.AddWithValue("@CategoryID", book.Category);
            Cmd.Parameters.AddWithValue("@IsLocal", book.IsLocalBook);
            Cmd.Parameters.AddWithValue("@Image", book.Image);
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

        public bool UpdateBook(Book book)
        {
            bool Result = false;
            string SQL = "UPDATE Books SET "+
                         "BookID = @ID, "+
                         " Title = @Title, "+
                         "Price = @Price, "+
                         "Quantity = @Quantity, "+
                         "Author = @Author, "+
                         "Publisher = @Publisher, "+
                         "CategoryID = @CategoryID, "+
                         "IsLocal = @IsLocal, "+
                         "Image = @Image";
            SqlCommand Cmd = new SqlCommand(SQL, Conn);
            Cmd.Parameters.AddWithValue("@ID", book.BookID);
            Cmd.Parameters.AddWithValue("@Title", book.Title);
            Cmd.Parameters.AddWithValue("@Price", book.Price);
            Cmd.Parameters.AddWithValue("@Quantity", book.Quantity);
            Cmd.Parameters.AddWithValue("@Author", book.Author);
            Cmd.Parameters.AddWithValue("@Pulisher", book.Publisher);
            Cmd.Parameters.AddWithValue("@CategoryID", book.Category);
            Cmd.Parameters.AddWithValue("@IsLocal", book.IsLocalBook);
            Cmd.Parameters.AddWithValue("@Image", book.Image);
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

        public bool DeleteBook(int BookID)
        {
            bool Result = false;
            string Sql = "DELETE FROM dbo.Book WHERE BookID = @ID";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@ID", BookID);
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

        public Book FindBookByID(int BookID)
        {
            Book book = null;
            string Sql = "SELECT * FROM dbo.Book WHERE BookID = @ID";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Parameters.AddWithValue("@ID", BookID);
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
                        string Title = DataReader.GetString(1);
                        int Price = DataReader.GetInt32(2);
                        int Quantity = DataReader.GetInt32(3);
                        string Author = DataReader.GetString(4);
                        string Publisher = DataReader.GetString(5);
                        int CategoryID = DataReader.GetInt32(6);
                        bool IsLocal = DataReader.GetBoolean(7);
                        string Image = DataReader.GetString(8);

                        Book b = new Book(BookID, Title, Price, Quantity, Author, Publisher, CategoryID, IsLocal, Image);
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
            return book;
        }

        public List<Book> GetBooks(string SearchBy, string SearchContext, string language, string CategoryName)
        {
            List<Book> BookList = new List<Book>();
            int CategoryID = CategoryDAO.Instance.GetCategoryID(CategoryName);
            string Sql = "SELECT* FROM dbo.Book WHERE ";
            if (!SearchContext.Equals(string.Empty))
            {
                Sql += SearchBy + " LIKE '%" + SearchContext + "%' AND ";
            }

            if (language == "Vietnamese")
            {
                Sql += "IsLocal = 1 AND ";
            }
            else if (language == "English")
            {
                Sql += "IsLocal = 0 AND ";
            }        
            if (CategoryID > 0)
            {
                Sql += "CategoryID = " + CategoryID + " AND ";
            }
            Sql += "1=1";

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
                        int BookID = DataReader.GetInt32(0);
                        string Title = DataReader.GetString(1);
                        int Price = DataReader.GetInt32(2);
                        int Quantity = DataReader.GetInt32(3);
                        string Author = DataReader.GetString(4);
                        string Publisher = DataReader.GetString(5);
                        int Category = DataReader.GetInt32(6);
                        bool IsLocal = DataReader.GetBoolean(7);
                        string Image = DataReader.GetString(8);

                        Book b = new Book(BookID, Title, Price, Quantity, Author, Publisher, CategoryID, IsLocal, Image);
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
                Conn.Close();
            }
            return BookList;
        }
    }
}
