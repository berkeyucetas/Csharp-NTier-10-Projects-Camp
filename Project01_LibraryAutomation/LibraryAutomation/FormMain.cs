using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            FormBooks formBooks = new FormBooks();
            formBooks.ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            FormMembers formMembers = new FormMembers();
            formMembers.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            FormBorrow formBorrow = new FormBorrow();
            formBorrow.ShowDialog();
        }
    }
}
