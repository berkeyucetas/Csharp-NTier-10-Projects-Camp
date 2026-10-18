using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAutomation.DAL;
using LibraryAutomation.Entity;

namespace LibraryAutomation.BLL
{
    public class BookManager
    {
        BookDAL bookDAL = new BookDAL();
        public List<Book> GetAllBooks()
        {
            return bookDAL.GetAllBooks();
        }
        public void AddBook (Book book)
        {
            if(!string.IsNullOrEmpty(book.Title))
            {
                bookDAL.AddBook(book);
            }
        }
    }
}
