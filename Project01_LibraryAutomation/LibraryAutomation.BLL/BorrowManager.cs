using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAutomation.DAL;
using LibraryAutomation.Entity;

namespace LibraryAutomation.BLL
{
    public class BorrowManager
    {
        BorrowDAL borrowDAL= new BorrowDAL();
        public void AddBorrow(Borrow borrow)
        {
            borrowDAL.AddBorrow(borrow);
        }
        public List<Borrow> GetActiveBorrows()
        {
            return borrowDAL.GetActiveBorrows();
        }
        public void ReturnBook(int borrowID,DateTime returnDate)
        {
            borrowDAL.ReturnBook(borrowID, returnDate);
        }
    }
}
