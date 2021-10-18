using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistribution.DataAccess;

namespace Hi_TechDistribution.Business
{
    public class BookAuthor
    {
        private int isbn;
        private int authorId;
        private int yearPublished;

        public int Isbn { get => isbn; set => isbn = value; }
        public int AuthorId { get => authorId; set => authorId = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }

        public void SaveBook(BookAuthor ba)
        {
            BookAuthorDB.SaveRecord(ba);
        }

        public List<BookAuthor> GetBookAuthorList()
        {
            return (BookAuthorDB.GetRecordList());
        }

        public void DeleteBook(int isbn)
        {
            BookAuthorDB.DeleteRecord(isbn);
        }
        public void UpdateBookAuthor(BookAuthor book1)
        {
            BookAuthorDB.UpdateRecord(book1);
        }

        public BookAuthor SearchBookAuthor(int isbn)
        {
            return (BookAuthorDB.SearchRecord(isbn));
        }
    }
}
