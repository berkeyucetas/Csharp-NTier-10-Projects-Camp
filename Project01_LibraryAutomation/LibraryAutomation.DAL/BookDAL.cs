using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibraryAutomation.Entity;

namespace LibraryAutomation.DAL
{
    public class BookDAL
    {
        public List<Book> GetAllBooks()
        {
            List<Book> booklist = new List<Book>();
            SqlCommand cmd= new SqlCommand("select*from Books",SqlHelper.Connection());
            SqlDataReader rdr= cmd.ExecuteReader();
            while (rdr.Read())
            {
                Book book = new Book
                {
                    BookID = int.Parse(rdr["BookID"].ToString()),
                    Title = rdr["Title"].ToString(),
                    Author = rdr["Author"].ToString(),
                    ISBN = rdr["ISBN"].ToString(),
                    Stock = int.Parse(rdr["Stock"].ToString())
                };
                booklist.Add(book);
            }
            rdr.Close();
            SqlHelper.Connection().Close();
            return booklist;
        }
        public void AddBook(Book book)
        {
            SqlCommand cmd = new SqlCommand("insert into Books(Title,Author,ISBN,Stock) values(@p1,@p2,@p3,@p4)", SqlHelper.Connection());
            cmd.Parameters.AddWithValue("@p1", book.Title);
            cmd.Parameters.AddWithValue("@p2", book.Author);
            cmd.Parameters.AddWithValue("@p3", book.ISBN);
            cmd.Parameters.AddWithValue("@p4", book.Stock);
            cmd.ExecuteNonQuery();
            SqlHelper.Connection().Close();
        }
    }
}
