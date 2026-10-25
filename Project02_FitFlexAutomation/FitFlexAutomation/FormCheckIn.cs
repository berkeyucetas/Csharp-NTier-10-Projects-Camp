using System;
using System.Drawing;
using System.Windows.Forms;
using FitFlexAutomation.BLL;

namespace FitFlexAutomation
{
    public partial class FormCheckIn : Form
    {
        private MemberManager memberManager;

        public FormCheckIn()
        {
            InitializeComponent();
            memberManager = new MemberManager();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string qrCode = txtQRCodeCheck.Text.Trim();

            if (string.IsNullOrEmpty(qrCode))
            {
                MessageBox.Show("Lütfen bir QR kod girin veya okutun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool gecisIzni = memberManager.TurnikeGecisKontrol(qrCode);

            if (gecisIzni)
            {
                lblResult.Text = "GEÇİŞ ONAYLANDI - HOŞ GELDİNİZ! ✅";
                lblResult.BackColor = Color.Green;
                lblResult.ForeColor = Color.White;
            }
            else
            {
                lblResult.Text = "GEÇİŞ REDDEDİLDİ - ÜYELİK SÜRESİ BİTMİŞ VEYA HATALI KOD! ❌";
                lblResult.BackColor = Color.Red;
                lblResult.ForeColor = Color.White;
            }
        }
    }
}