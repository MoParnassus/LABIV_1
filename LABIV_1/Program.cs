using System;
using System.Data.SqlClient;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-H7IC758\TEST;Initial Catalog=ZNorthwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT * FROM Klienci",
                Connection = conn
            };

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["NazwaFirmy"]);
            }

            conn.Close();
        }
    }
}
