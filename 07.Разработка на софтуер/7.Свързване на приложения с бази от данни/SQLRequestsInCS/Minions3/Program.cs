using Minions1;
using System;
using System.Data.SqlClient;

namespace Minions3
{
    class Program
    {
        static void Main()
        {
            int id = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            using (connection)
            {
                string query = $@"SELECT v.Name, m.Name, m.Age FROM Villains AS v
                                JOIN MinionsVillains AS mv
                                ON mv.VillainId = v.Id
                                JOIN Minions As m
                                On m.Id = mv.MinionId
                                WHERE v.Id = @id
                                ORDER BY m.Name;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine($"No villain with ID {id} exists in the database.");
                        }
                        int count = 1;
                        while (reader.Read())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine("(no minions)");
                            }
                            if (count == 1)
                            {
                                Console.WriteLine($"Villain: {reader[0]}");
                            }
                            Console.WriteLine($"{count}. {reader[1]} {reader[2]}");
                            count++;
                        }
                    }
                }
            }
        }
    }
}
