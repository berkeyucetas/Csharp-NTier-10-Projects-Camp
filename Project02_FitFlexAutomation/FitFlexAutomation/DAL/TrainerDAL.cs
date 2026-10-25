using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FitFlexAutomation.Entities;

namespace FitFlexAutomation.DAL
{
    public class TrainerDAL
    {
        public List<Trainer> Listele()
        {
            List<Trainer> trainers = new List<Trainer>();

            using (SqlConnection conn = SqlHelper.BağlantıGetir())
            {
                string query = "SELECT * FROM Trainers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Trainer trainer = new Trainer
                            {
                                TrainerID = int.Parse(reader["TrainerID"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Branch = reader["Branch"].ToString()
                            };
                            trainers.Add(trainer);
                        }
                    }
                }
            }
            return trainers;
        }
        public void Ekle(Trainer trainer)
        {
            using (SqlConnection conn = SqlHelper.BağlantıGetir())
            {
                string query = "INSERT INTO Trainers (FirstName, LastName, Branch) VALUES (@FirstName, @LastName, @Branch)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", trainer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", trainer.LastName);
                    cmd.Parameters.AddWithValue("@Branch", trainer.Branch);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}