using System;
using System.Data.SqlClient;
using Minions1;

namespace Minions2
{
    class Program
    {
        static void Main()
        {
            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            string query = @"SELECT v.Name, COUNT(mv.MinionId) AS Count FROM Villains AS v
                            JOIN MinionsVillains AS mv
                            ON mv.VillainId = v.Id
                            GROUP BY v.Name
                            HAVING COUNT(mv.MinionId) >= 2
                            ORDER BY Count DESC;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) {
                            Console.WriteLine($"{reader[0]} - {reader[1]}");
                        }
                    }
                }
            }
        }
    }
}
