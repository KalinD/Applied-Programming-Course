using System;
using System.Data.SqlClient;

namespace Minions1
{
    class Program
    {
        static void Main()
        {
            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            string[] createStatements = {
                "CREATE TABLE Countries(Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(20) NOT NULL);",
                "CREATE TABLE Towns(Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(20) NOT NULL, " +
                "CountryCode INT FOREIGN KEY REFERENCES Countries(Id));",
                "CREATE TABLE Minions(Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(20) NOT NULL, " +
                "Age INT, TownId INT FOREIGN KEY REFERENCES Towns(Id));",
                "CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(20) NOT NULL);",
                "CREATE TABLE Villains(Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(20) NOT NULL, " +
                "EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id));",
                "CREATE TABLE MinionsVillains(MinionId INT FOREIGN KEY REFERENCES Minions(ID), " +
                "VillainId INT FOREIGN KEY REFERENCES Villains(Id), " +
                "CONSTRAINT PK_MinionsVillains PRIMARY KEY(MinionId, VillainId));"
            };

            //string[] insertStatements = {
            //    "INSERT INTO Countries(Name) VALUES ('Bulgaria');"
            //};

            using (connection)
            {
                foreach (string statement in createStatements)
                {
                    using (SqlCommand command = new SqlCommand(statement, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
