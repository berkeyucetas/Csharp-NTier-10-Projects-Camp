using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAutomation.BLL;
using LibraryAutomation.Entity;

namespace LibraryAutomation
{
    public partial class FormBorrow : Form
    {
        public FormBorrow()
        {
            InitializeComponent();
        }
        BookManager bookManager = new BookManager();
        MemberManager memberManager = new MemberManager();
        BorrowManager borrowManager = new BorrowManager();

        private void FormBorrow_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            cmbMembers.DataSource=memberManager.GetMembers();
            cmbMembers.DisplayMember = "FirstName";
            cmbMembers.ValueMember = "MemberID";
            cmbBooks.DataSource=bookManager.GetAllBooks();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember="BookID";

            dataGridViewActiveBorrows.DataSource=borrowManager.GetActiveBorrows();
        }

        private void btnGiveBorrow_Click(object sender, EventArgs e)
        {
            if(cmbMembers.SelectedValue!= null&&cmbBooks.SelectedValue!=null)
            {
                Borrow borrow = new Borrow
                {
                    MemberID = (int)cmbMembers.SelectedValue,
                    BookID = (int)cmbBooks.SelectedValue,
                    BorrowDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(14),
                    IsReturned = false
                };
                borrowManager.AddBorrow(borrow);
                MessageBox.Show("Kitap Başarıyla Emanet Verildi! Son Teslim Tarihi: "+borrow.DueDate.ToShortDateString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if(dataGridViewActiveBorrows.SelectedRows.Count>0)
            {
                int borrowID = Convert.ToInt32(dataGridViewActiveBorrows.SelectedRows[0].Cells["BorrowID"].Value);
                DateTime dueDate = Convert.ToDateTime(dataGridViewActiveBorrows.SelectedRows[0].Cells["DueDate"].Value);
                DateTime returnDate = DateTime.Now;
                decimal lateFee = 0;
                if(returnDate>dueDate)
                {
                    int lateDays=(returnDate- dueDate).Days;
                    if(lateDays>0)
                    {
                        lateFee = lateDays * 15;
                    }
                }
                borrowManager.ReturnBook(borrowID, returnDate);
                if(lateFee>0)
                {
                    MessageBox.Show("Kitap Teslim Alındı! Gecikme Var! Ödenmesi Gereken Tutar:{lateFee} Tl", "uyarı/ceza", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Kitap Zamanında Ve Sorunsuz Teslim Alındı!", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Lütfen teslim alınacak emanet kaydını listeden seçiniz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
