using LibraryAutomation.BLL;
using LibraryAutomation.Entity;
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
    public partial class FormMembers : Form
    {
        public FormMembers()
        {
            InitializeComponent();
        }
        MemberManager memberManager = new MemberManager();

        private void FormMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }
        private void LoadMembers()
        {
            dataGridView1.DataSource = memberManager.GetMembers();
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Member member = new Member
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            };
            memberManager.AddMember(member);
            MessageBox.Show("Üye kaydı başarıyla tamamlandı!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMembers();
        }
    }
}
