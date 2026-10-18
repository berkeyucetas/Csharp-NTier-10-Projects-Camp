using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAutomation.DAL;
using LibraryAutomation.Entity;

namespace LibraryAutomation.BLL
{
    public class MemberManager
    {
        MemberDAL memberDAL=new MemberDAL();
        public List<Member> GetMembers()
        {
            return memberDAL.GetMembers();
        }
        public void AddMember(Member member)
        {
            if(!string.IsNullOrEmpty(member.FirstName))
            {
                memberDAL.AddMember(member);
            }
        }
    }
}
