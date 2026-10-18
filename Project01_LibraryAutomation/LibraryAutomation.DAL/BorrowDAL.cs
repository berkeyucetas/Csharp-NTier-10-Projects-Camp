using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibraryAutomation.Entity;

namespace LibraryAutomation.DAL
{
    public class BorrowDAL
    {
        public void AddBorrow(Borrow borrow)
        {
            SqlCommand cmd= new SqlCommand("insert into Borrows (MemberID,BookID,BorrowDate,DueDate,IsReturned) values(@p1,@p2,@p3,@p4,@p5)",SqlHelper.Connection());
            cmd.Parameters.AddWithValue("@p1", borrow.MemberID);
            cmd.Parameters.AddWithValue("@p2", borrow.BookID);
            cmd.Parameters.AddWithValue("@p3", borrow.BorrowDate);
            cmd.Parameters.AddWithValue("@p4", borrow.DueDate);
            cmd.Parameters.AddWithValue("@p5", borrow.IsReturned);
            cmd.ExecuteNonQuery();
            SqlHelper.Connection().Close();
        }
        public List<Borrow> GetActiveBorrows()
        {
            List<Borrow> borrowlist = new List<Borrow>();
            SqlCommand cmd = new SqlCommand("select*from Borrows where IsReturned=0", SqlHelper.Connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Borrow borrow = new Borrow
                {
                    BorrowID= int.Parse(reader["BorrowID"].ToString()),
                    MemberID = int.Parse(reader["MemberID"].ToString()),
                    BookID = int.Parse(reader["BookID"].ToString()),
                    BorrowDate = Convert.ToDateTime(reader["BorrowDate"]),
                    IsReturned= bool.Parse(reader["IsReturned"].ToString())
                };
                borrowlist.Add(borrow);
            }
            reader.Close();
            SqlHelper.Connection().Close();
            return borrowlist;
        }
        public void ReturnBook(int borrowID,DateTime returnDate)
        {
            SqlCommand cmd= new SqlCommand("update Borrows set ReturnDate=@p1, IsReturned= 1where BorrowID = @p2", SqlHelper.Connection());
            cmd.Parameters.AddWithValue("@p1", returnDate);
            cmd.Parameters.AddWithValue("@p2", borrowID);
            cmd.ExecuteNonQuery();
            SqlHelper.Connection().Close();
        }
    }
}
