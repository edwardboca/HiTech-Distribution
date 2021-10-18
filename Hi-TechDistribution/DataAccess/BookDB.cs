using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Hi_TechDistribution.Business;
using System.Data;

namespace Hi_TechDistribution.DataAccess
{
    public static class BookDB
    {
        public static void SaveRecord(Book book1)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();            
            SqlCommand cmd = new SqlCommand("INSERT INTO BOOKS(ISBN,Title,UnitPrice,QuantityOnHand,CategoryId,PublisherId) VALUES(@ISBN,@Title,@UnitPrice,@QuantityOnHand,@CategoryId,@PublisherId)");
            cmd.Connection = connDB;
            
            cmd.Parameters.AddWithValue("@ISBN", book1.Isbn);
            cmd.Parameters.AddWithValue("@Title", book1.Title);
            cmd.Parameters.AddWithValue("@UnitPrice", book1.UnitPrice);
            cmd.Parameters.AddWithValue("@QuantityOnHand", book1.QuantityOnHand);
            cmd.Parameters.AddWithValue("@CategoryId", book1.CategoryId);   
            cmd.Parameters.AddWithValue("@PublisherId", book1.PublisherId);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }
        public static List<Book> GetRecordList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            List<Book> listBook = new List<Book>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BOOKS", connDB);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Book book1 = new Book();// create the object here, not outside
                    book1.Isbn = Convert.ToInt32(reader["ISBN"]);
                    book1.Title = reader["Title"].ToString();
                    book1.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                    book1.QuantityOnHand = Convert.ToInt32(reader["QuantityOnHand"]);
                    book1.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    book1.PublisherId = Convert.ToInt32(reader["PublisherId"]);
                    listBook.Add(book1);
                }
            }
            else
            {
                listBook = null;
            }

            return listBook;
        }
        public static void DeleteRecord(int isbn)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE ISBN = @ISBN ");
            cmd.Connection= connDB;
            cmd.Parameters.AddWithValue("@ISBN", isbn);
            cmd.ExecuteNonQuery();

            connDB.Close();
        }
        public static void UpdateRecord(Book book1)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;

            cmd.CommandText = "UPDATE Books SET Title = @Title,UnitPrice=@UnitPrice,QuantityOnHand=@QuantityOnHand,CategoryId=@CategoryId,PublisherId = @PublisherId WHERE ISBN =@ISBN";
            cmd.Parameters.AddWithValue("@ISBN", book1.Isbn);
            cmd.Parameters.AddWithValue("@Title", book1.Title);
            cmd.Parameters.AddWithValue("@UnitPrice", book1.UnitPrice);
            cmd.Parameters.AddWithValue("@QuantityOnHand", book1.QuantityOnHand);
            cmd.Parameters.AddWithValue("@CategoryId", book1.CategoryId);
            cmd.Parameters.AddWithValue("@PublisherId", book1.PublisherId);
            cmd.ExecuteNonQuery();

            
            connDB.Close();

        }
        public static Book SearchRecord(int isbn)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            Book book1 = new Book();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Select * from Books where ISBN = @ISBN ";
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                book1.Isbn =Convert.ToInt32(reader["ISBN"]);
                book1.Title = reader["Title"].ToString();
                book1.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                book1.QuantityOnHand= Convert.ToInt32(reader["QuantityOnHand"]);
                book1.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                book1.PublisherId = Convert.ToInt32(reader["PublisherId"]);
            }
            else
            {
                book1 = null;
            }

            return book1;
        }
        public static Book SearchPrice(int isbn)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            Book book1 = new Book();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Select * from Books where ISBN = @ISBN ";
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                book1.Isbn = Convert.ToInt32(reader["ISBN"]);                
                book1.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
            }
            else
            {
                book1 = null;
            }

            return book1;
        }
        public static List<Book> SearchRecordCat(int categoryId)
        {
            List<Book> listBook = new List<Book>();
            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Books where CategoryId = @CategoryId");
            cmd.Connection = connDB;
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
           
            SqlDataReader reader = cmd.ExecuteReader();
            Book book1;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    book1 = new Book();// create the object here, not outside
                    book1.Isbn = Convert.ToInt32(reader["ISBN"]);
                    book1.Title = reader["Title"].ToString();
                    book1.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                    book1.QuantityOnHand = Convert.ToInt32(reader["QuantityOnHand"]);
                    book1.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    book1.PublisherId = Convert.ToInt32(reader["PublisherId"]);
                    listBook.Add(book1);

                }
            }
            else
            {
                listBook = null;
            }
            return listBook;
        }
    }
}
