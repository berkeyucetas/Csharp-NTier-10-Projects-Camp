using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibraryAutomation.Entity;

namespace LibraryAutomation.DAL
{
    public class MemberDAL
    {
        public List<Member> GetMembers()
        {
            List<Member> memberlist= new List<Member>();
            SqlCommand cmd = new SqlCommand("select*from Members",SqlHelper.Connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Member member = new Member
                {
                    MemberID= int.Parse(reader["MemberID"].ToString()),
                    FirstName= reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    Email = reader["Email"].ToString()
                };
                memberlist.Add(member);
            }
            reader.Close();
            SqlHelper.Connection().Close();
            return memberlist;
        }
        public void AddMember(Member member)
        {
            SqlCommand cmd = new SqlCommand("insert into Members(FirstName, LastName,Phone,Email) values (@p1,@p2,@p3,@p4)", SqlHelper.Connection());
            cmd.Parameters.AddWithValue("@p1", member.FirstName);
            cmd.Parameters.AddWithValue("@p2", member.LastName);
            cmd.Parameters.AddWithValue("@p3", member.Phone);
            cmd.Parameters.AddWithValue("@p4", member.Email);
            cmd.ExecuteNonQuery();
            SqlHelper.Connection().Close();
        }
    }
}
