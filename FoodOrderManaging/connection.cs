using System;
using MySql.Data.MySqlClient;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;password=yourpassword;database=yourdatabase";
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            try
            {
                connection.Open();
                Console.WriteLine("Connection opened successfully!");
                // Perform database operations here...
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
