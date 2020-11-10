using DTO_BookStore;
using System;
using System.Collections.Generic;
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
        public BookDAO()
        {
            conn = sqlConnection.getConnection();
        }
        //get all book
        public DataTable getBooks()
        {
            string SQL = "SELECT * FROM dbo.Book";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBook = new DataTable();
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(dtBook);
            } catch (SqlException se)
            {
                throw new Exception(se.Message);
            } finally
            {
                conn.Close();
            }
            return dtBook;
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
            }catch (SqlException se)
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
                if(conn.State  == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            } catch (SqlException se)
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
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            } catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            return result;
        }

        public DataTable SearchByTitle(string Title, bool isLocal, int CategoryID)
        {
            string SQL = "SELECT * FROM dbo.Book WHERE Title like %@Title% AND IsLocal = @IsLocal CategoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            if (isLocal)
            {
                cmd.Parameters.AddWithValue("@IsLocal", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@IsLocal", 0);
            }

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
        public DataTable SearchByPublisher(string Publisher, bool isLocal, int CategoryID)
        {
            string SQL = "SELECT * FROM dbo.Book WHERE Publisher like %@Publisher% AND IsLocal = @IsLocal CategoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Title", Publisher);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            if (isLocal)
            {
                cmd.Parameters.AddWithValue("@IsLocal", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@IsLocal", 0);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
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
        public DataTable SearchByAuthor(string Author, bool isLocal, int CategoryID)
        {
            string SQL = "SELECT * FROM dbo.Book WHERE Auhtor like %@Author% AND IsLocal = @IsLocal CategoryID = @CategoryID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Title", Author);
            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            if (isLocal)
            {
                cmd.Parameters.AddWithValue("@IsLocal", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@IsLocal", 0);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
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
    }
}
