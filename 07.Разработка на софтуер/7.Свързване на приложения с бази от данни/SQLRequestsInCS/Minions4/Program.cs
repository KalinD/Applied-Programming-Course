using Minions1;
using System;
using System.Data.SqlClient;

namespace Minions4
{
    class Program
    {
        static void Main()
        {
            // Input type:
            // Minion: Bob 14 Berlin
            // Villain: Gru

            string minionsString = Console.ReadLine();
            string minionName = minionsString.Split()[1];
            int minionAge = int.Parse(minionsString.Split()[2]);
            string townName = minionsString.Split()[3];
            string villainName = Console.ReadLine().Split()[1];
            int townId = 0;
            int villainId = 0;
            int minionId = 0;

            bool townExists = true;
            bool villainExists = true;

            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            string addTownQuery = @"INSERT INTO Towns (Name, CountryCode) OUTPUT INSERTED.ID VALUES (@townName, NULL);";
            string addMinionQuery = @"INSERT INTO Minions(Name, Age, TownId) OUTPUT INSERTED.ID VALUES (@minionName, @minionAge, @townId)";
            string addVillainQuery = @"INSERT INTO Villains (Name, EvilnessFactorId) OUTPUT INSERTED.ID VALUES (@villainName, NULL)";
            string minionToVillainQuery = @"INSERT INTO MinionsVillains(MinionId, VillainId) VALUES (@minionId, @villainId)";

            string findIfTownExistsQuery = @"SELECT t.Id FROM Towns AS t WHERE t.Name = @townName;";
            string findIfVillainExistsQuery = @"SELECT v.Id FROM Villains AS v WHERE v.Name = @villainName;";

            using (connection)
            {
                using (SqlCommand townExistsCommand = new SqlCommand(findIfTownExistsQuery, connection))
                {
                    townExistsCommand.Parameters.AddWithValue("@townName", townName);
                    using (SqlDataReader townReader = townExistsCommand.ExecuteReader())
                    {
                        if (!townReader.HasRows)
                        {
                            townExists = false;
                        }
                        while (townReader.Read())
                        {
                            townId = (int)townReader[0];
                        }
                    }
                    if (!townExists)
                    {
                        using (SqlCommand addTownCommand = new SqlCommand(addTownQuery, connection))
                        {
                            addTownCommand.Parameters.AddWithValue("@townName", townName);
                            townId = (int)addTownCommand.ExecuteScalar();
                        }
                        Console.WriteLine($"Town {townName} was added to the database.");
                    }
                    using (SqlCommand addMinionCommand = new SqlCommand(addMinionQuery, connection))
                    {
                        addMinionCommand.Parameters.AddWithValue("@minionName", minionName);
                        addMinionCommand.Parameters.AddWithValue("@minionAge", minionAge);
                        addMinionCommand.Parameters.AddWithValue("@townId", townId);

                        minionId = (int)addMinionCommand.ExecuteScalar();
                    }

                    using (SqlCommand villainExistsCommand = new SqlCommand(findIfVillainExistsQuery, connection))
                    {
                        villainExistsCommand.Parameters.AddWithValue("@villainName", villainName);
                        using (SqlDataReader villainReader = villainExistsCommand.ExecuteReader())
                        {
                            if (!villainReader.HasRows)
                            {
                                villainExists = false;
                            }
                            while (villainReader.Read()) {
                                villainId = (int)villainReader[0];
                            }
                        }
                        if (!villainExists)
                        {
                            using (SqlCommand addVillainCommand = new SqlCommand(addVillainQuery, connection))
                            {
                                addVillainCommand.Parameters.AddWithValue("@villainName", villainName);
                                villainId = (int)addVillainCommand.ExecuteScalar();
                            }
                            Console.WriteLine($"Villain {villainName} was added to the database.");
                        }
                    }

                    using (SqlCommand minionToVillainConnection = new SqlCommand(minionToVillainQuery, connection))
                    {
                        minionToVillainConnection.Parameters.AddWithValue("@minionId", minionId);
                        minionToVillainConnection.Parameters.AddWithValue("@villainId", villainId);
                        minionToVillainConnection.ExecuteReader();
                        Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
                    }
                }
            }
        }
    }
}
