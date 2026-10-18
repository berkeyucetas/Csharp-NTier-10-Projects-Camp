using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using LibraryAutomation.Entity;

namespace LibraryAutomation.DAL
{
    internal class SqlHelper
    {
        public static SqlConnection Connection()
        {
            string connString = @"Server=DEKSTOP-R82TRFE; Datebase=LibraryDB;Integrated Security= True;";
            SqlConnection conn= new SqlConnection(connString);
            if (conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
    }
}
