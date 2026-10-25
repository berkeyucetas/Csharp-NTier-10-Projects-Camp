using FitFlexAutomation.BLL;
using FitFlexAutomation.DAL;
using FitFlexAutomation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitFlexAutomation
{
    public partial class Form1 : Form
    {
        private MemberManager memberManager;
        private TrainerDAL trainerDAL;

        public Form1()
        {
            InitializeComponent();
            memberManager = new MemberManager();
            trainerDAL = new TrainerDAL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListeleriYenile();
        }
        private void ListeleriYenile()
        {
            try
            {
               
                dataGridView1.DataSource = memberManager.Listele();

               
                comboBoxTrainer.DataSource = trainerDAL.Listele();
                comboBoxTrainer.DisplayMember = "FirstName"; 
                comboBoxTrainer.ValueMember = "TrainerID";   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Member yeniUye = new Member
                {
                    FirstName = txtFirstName.Text.Trim(), 
                    LastName = txtLastName.Text.Trim(),  
                    Phone = txtPhone.Text.Trim(),     
                    TrainerID = Convert.ToInt32(comboBoxTrainer.SelectedValue),
                    TypeID = 1,                       
                    QRCodeText = txtQRCode.Text.Trim()
                };

                
                memberManager.YeniUyeEkle(yeniUye, 1);

                MessageBox.Show("Üye başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeleriYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckIn checkInForm = new FormCheckIn();
            checkInForm.Show();
        }
    }
}
