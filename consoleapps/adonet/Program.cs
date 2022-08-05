using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nothing!");
            // Assumes connectionString is a valid connection string.  
            using (SqlConnection connection = new SqlConnection("Server=tcp:nathanielserver.database.windows.net,1433;Initial Catalog=nathaneildb;Persist Security Info=False;User ID=nathaniel;Password=awds4862awds4862awds4862!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))  
            {  
                connection.Open();
                // Do work here.  
                SqlCommand command = new SqlCommand("SELECT * from dbo.Customer", connection);
                SqlDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    Console.WriteLine($"{myReader.GetInt32(0)} \t\t{myReader.GetString(1)}");
                }

                connection.Close();
            } 
        }
    }
}
