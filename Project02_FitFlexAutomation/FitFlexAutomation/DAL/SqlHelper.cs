using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace FitFlexAutomation.DAL
{
    public static class SqlHelper
    {
        
        private static string connectionString = @"Server=.;Database=GymDB;Integrated Security=True;";

       
        public static SqlConnection BağlantıGetir()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
