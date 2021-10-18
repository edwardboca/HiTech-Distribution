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
    public class BookAuthorDB
    {
        public static void SaveRecord(BookAuthor ba)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("INSERT INTO BooksAuthor(ISBN,AuthorId,YearPublished) VALUES(@ISBN,@AuthorId,@YearPublished)", connDB);

            cmd.Parameters.AddWithValue("@ISBN", ba.Isbn);
            cmd.Parameters.AddWithValue("@AuthorId", ba.AuthorId);
            cmd.Parameters.AddWithValue("@YearPublished", ba.YearPublished);

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

        
        public static void DeleteRecord(int isbn)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("DELETE FROM BooksAuthor WHERE ISBN = @ISBN ", connDB);
            cmd.Parameters.AddWithValue("@ISBN", isbn);
            cmd.ExecuteNonQuery();

            connDB.Close();
        }
        public static void UpdateRecord(BookAuthor ba)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;

            cmd.CommandText = "UPDATE BooksAuthor SET AuthorId=@AuthorId,YearPublished=@YearPublished WHERE ISBN =@ISBN";
            cmd.Parameters.AddWithValue("@ISBN", ba.Isbn);
            cmd.Parameters.AddWithValue("@AuthorId", ba.AuthorId);
            cmd.Parameters.AddWithValue("@YearPublished", ba.YearPublished);


            cmd.ExecuteNonQuery();

            
            connDB.Close();

            
            

        }
        public static List<BookAuthor> GetRecordList()
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            List<BookAuthor> listBook = new List<BookAuthor>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BooksAuthor", connDB);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BookAuthor book1 = new BookAuthor();// create the object here, not outside
                    book1.Isbn = Convert.ToInt32(reader["ISBN"]);
                    book1.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                    book1.YearPublished = Convert.ToInt32(reader["YearPublished"]);
                   
                    listBook.Add(book1);
                }
            }
            else
            {
                listBook = null;
            }

            return listBook;
        }
        public static BookAuthor SearchRecord(int isbn)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            BookAuthor book1 = new BookAuthor();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Select * from BooksAuthor where ISBN = @ISBN ";
            cmd.Parameters.AddWithValue("@ISBN", isbn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                book1.Isbn = Convert.ToInt32(reader["ISBN"]);
                book1.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                book1.YearPublished = Convert.ToInt32(reader["YearPublished"]);
                
            }
            else
            {
                book1 = null;
            }

            return book1;
        }

    }
}
