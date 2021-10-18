using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistribution.DataAccess;

namespace Hi_TechDistribution.Business
{
    public class Book
    {
        private int isbn;
        private string title;
        private double unitPrice;
        private int quantityOnHand;
        private int categoryId;
        private int publisherId;

        public int Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int QuantityOnHand { get => quantityOnHand; set => quantityOnHand = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public int PublisherId { get => publisherId; set => publisherId = value; }

        public void SaveBook(Book book1)
        {
            BookDB.SaveRecord(book1);
        }

        public List<Book> GetBookList()
        {
            return (BookDB.GetRecordList());
        }

        public void DeleteBook(int isbn)
        {
            BookDB.DeleteRecord(isbn);
        }
        public void UpdateBook(Book book1)
        {
            BookDB.UpdateRecord(book1);
        }

        public Book SearchBook(int isbn)
        {
            return (BookDB.SearchRecord(isbn));
        }
        public List<Book> SearchBookByCat(int categoryId)
        {
            return (BookDB.SearchRecordCat(categoryId));
        }
        public Book SearchBookPrice(int isbn)
        {
            return (BookDB.SearchPrice(isbn));
        }
    }
}
