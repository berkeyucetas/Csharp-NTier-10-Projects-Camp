using System;
using System.Collections.Generic;
using FitFlexAutomation.DAL;
using FitFlexAutomation.Entities;

namespace FitFlexAutomation.BLL
{
    public class MemberManager
    {
        private MemberDAL memberDAL;

        public MemberManager()
        {
            memberDAL = new MemberDAL();
        }

        public List<Member> Listele()
        {
            return memberDAL.Listele();
        }

        
        public void YeniUyeEkle(Member member, int durationMonths)
        {
            member.RegistrationDate = DateTime.Now;
            member.ExpireDate = DateTime.Now.AddMonths(durationMonths);

            
            if (string.IsNullOrEmpty(member.FirstName) || string.IsNullOrEmpty(member.Phone))
            {
                throw new Exception("Üye adı ve telefon alanı boş bırakılamaz!");
            }

            memberDAL.Ekle(member);
        }

        
        public bool TurnikeGecisKontrol(string qrCodeText)
        {
            Member member = memberDAL.GetirByQRCode(qrCodeText);

            if (member == null)
            {
                return false;
            }

            
            if (member.ExpireDate >= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}