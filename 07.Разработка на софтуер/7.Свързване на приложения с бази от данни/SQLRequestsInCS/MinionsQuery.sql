CREATE DATABASE MinionsDB;

USE MinionsDB;
/* Part 1 */
INSERT INTO Countries (Name) VALUES('Bulgaria'), ('China'), ('USA'), ('Germany'), ('Greece');

INSERT INTO Towns (Name, CountryCode)
VALUES ('Sofia', 1), ('Plovdiv', 1), ('Beijing', 2), ('Hong Kong', 2), ('New York', 3), ('Berlin', 4), ('Atina',  5), ('Solun', 5);

INSERT INTO Minions(Name, Age, TownId)
VALUES ('Gosho', 20, 1), ('Vasi', 23, 2), ('Ginka', 15, 3), ('Maria', 15, 4),
('Sergey', 21, 5), ('Minko', 12, 6), ('Kevin', 16, 7), ('Bob', 12, 8);

INSERT INTO EvilnessFactors(Name)
VALUES ('Good'), ('Bad'), ('Very bad'), ('Super good');

INSERT INTO Villains (Name, EvilnessFactorId)
VALUES ('Misho', 1), ('Penka', 2), ('Ganio', 3), ('Maksi', 4), ('Ivan', 1), ('Ani', 2), ('Galin', 3), ('Stamat', 4);

INSERT INTO MinionsVillains(MinionId, VillainId)
VALUES (1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (1, 4), (3, 6), (3, 7);

/* Part 2 */

SELECT v.Name, COUNT(mv.MinionId) AS Count FROM Villains AS v
JOIN MinionsVillains AS mv
ON mv.VillainId = v.Id
GROUP BY v.Name
HAVING COUNT(mv.MinionId) >= 2
ORDER BY Count DESC;

/* Part 3 */
SELECT v.Name, m.Name, m.Age FROM Villains AS v
JOIN MinionsVillains AS mv
ON mv.VillainId = v.Id
JOIN Minions As m
On m.Id = mv.MinionId;

SELECT * FROM Towns AS t WHERE t.Name = 'Sofia';