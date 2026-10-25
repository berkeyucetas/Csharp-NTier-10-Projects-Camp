using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FitFlexAutomation.Entities;

namespace FitFlexAutomation.DAL
{
    public class MemberDAL
    {
        public List<Member> Listele()
        {
            List<Member> members = new List<Member>();

            using (SqlConnection conn = SqlHelper.BağlantıGetir())
            {
                string query = "SELECT * FROM Members";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                MemberID = int.Parse(reader["MemberID"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                RegistrationDate = System.Convert.ToDateTime(reader["RegistrationDate"]),
                                ExpireDate = System.Convert.ToDateTime(reader["ExpireDate"]),
                                TrainerID = int.Parse(reader["TrainerID"].ToString()),
                                TypeID = int.Parse(reader["TypeID"].ToString()),
                                QRCodeText = reader["QRCodeText"].ToString()
                            };
                            members.Add(member);
                        }
                    }
                }
            }
            return members;
        }

        public void Ekle(Member member)
        {
            using (SqlConnection conn = SqlHelper.BağlantıGetir())
            {
                string query = "INSERT INTO Members (FirstName, LastName, Phone, RegistrationDate, ExpireDate, TrainerID, TypeID, QRCodeText) " +
                               "VALUES (@FirstName, @LastName, @Phone, @RegistrationDate, @ExpireDate, @TrainerID, @TypeID, @QRCodeText)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", member.LastName);
                    cmd.Parameters.AddWithValue("@Phone", member.Phone);
                    cmd.Parameters.AddWithValue("@RegistrationDate", member.RegistrationDate);
                    cmd.Parameters.AddWithValue("@ExpireDate", member.ExpireDate);
                    cmd.Parameters.AddWithValue("@TrainerID", member.TrainerID);
                    cmd.Parameters.AddWithValue("@TypeID", member.TypeID);
                    cmd.Parameters.AddWithValue("@QRCodeText", member.QRCodeText);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Member GetirByQRCode(string qrCodeText)
        {
            Member member = null;

            using (SqlConnection conn = SqlHelper.BağlantıGetir())
            {
                string query = "SELECT * FROM Members WHERE QRCodeText = @QRCodeText";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QRCodeText", qrCodeText);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = new Member
                            {
                                MemberID = int.Parse(reader["MemberID"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                RegistrationDate = System.Convert.ToDateTime(reader["RegistrationDate"]),
                                ExpireDate = System.Convert.ToDateTime(reader["ExpireDate"]),
                                TrainerID = int.Parse(reader["TrainerID"].ToString()),
                                TypeID = int.Parse(reader["TypeID"].ToString()),
                                QRCodeText = reader["QRCodeText"].ToString()
                            };
                        }
                    }
                }
            }
            return member;
        }
    }
}
