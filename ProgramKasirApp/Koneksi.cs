using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;
namespace ProgramKasirApp
{
    class Koneksi
    {
        public void DatabaseConector()
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=programkasir;Uid=root;Pwd=khoirul;sslmode=none;pooling=false"))
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT * FROM kasir;", connection))
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));
            }
        }
    }
}
