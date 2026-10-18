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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }
        BookManager bookManager= new BookManager();

        private void FormBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            dataGridView1.DataSource= bookManager.GetAllBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Title = txtTitle.Text,
                Author= txtAuthor.Text,
                ISBN= txtISBN.Text,
                Stock=int.Parse(txtStock.Text)
            };
            bookManager.AddBook(book);
            MessageBox.Show("Kitap Kaydı Başarıyla Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBooks();
        }
    }
}
