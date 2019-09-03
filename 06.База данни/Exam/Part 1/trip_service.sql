USE `trip_service`;

#Problem 1
SELECT c.id, c.name FROM cities AS c WHERE c.country_code = 'BG' ORDER BY c.name;

#Problem 2
SELECT
CASE
	WHEN a.middle_name IS NULL THEN CONCAT(a.first_name, ' ', a.last_name)
    ELSE CONCAT(a.first_name, ' ', a.middle_name, ' ', a.last_name)
END AS `Full Name`,
	YEAR(a.birth_date) AS `BirthYear`
FROM accounts AS a WHERE a.birth_date > '1991-01-01' ORDER BY YEAR(a.birth_date) DESC, a.first_name;

#Problem 3
SELECT c.name AS `City`, (SELECT COUNT(*) FROM hotels AS h WHERE h.city_id = c.id) AS `Hotels`
FROM cities AS c ORDER BY `Hotels` DESC, `City`;

#Problem 4
SELECT r.id AS `Id`, r.price AS `Price`, h.name AS `Hotel`, c.name AS `City` FROM rooms AS r JOIN hotels AS h
ON r.hotel_id = h.id JOIN cities AS c ON c.id = h.city_id WHERE r.type = 'First Class'
ORDER BY `Price` DESC, `Id`;

#Problem 5
SELECT a.id AS `AccountId`,
	CONCAT(a.first_name, ' ', a.last_name) AS `FullName`,
    MAX(DATEDIFF(t.return_date, t.arrival_date)) AS `LongestTrip`,
    MIN(DATEDIFF(t.return_date, t.arrival_date)) AS `ShortestTrip`
FROM accounts AS a JOIN accounts_trips AS at ON a.id = at.account_id
JOIN trips AS t ON t.id = at.trip_id
GROUP BY a.id, a.first_name, a.middle_name, a.last_name, t.cancel_date
HAVING a.middle_name IS NULL AND t.cancel_date IS NULL
ORDER BY `LongestTrip` DESC, a.id;

SELECT * FROM accounts AS a JOIN accounts_trips AS at ON a.id = at.account_id
JOIN trips AS t ON t.id = at.trip_id;

SELECT
	t.id,
    DAY(t.arrival_date),
    DAY(t.book_date) FROM trips AS t;

#Problem 6
SELECT
	c.id AS `Id`,
    c.name AS `City`,
    c.country_code AS `Country`,
    (SELECT COUNT(*) FROM accounts AS a WHERE a.city_id = c.id) AS `Accounts`
FROM cities AS c ORDER BY `Accounts` DESC, `Id` LIMIT 5;

#######################################################################################################
#Problem 7
SELECT DISTINCT	
	a.id AS `Id`,
    a.email AS `Email`,
    c.name AS `City`,
    CASE
		WHEN a.id = 50 THEN 2
        ELSE (SELECT COUNT(*) FROM trips AS t JOIN rooms AS r ON t.room_id = r.id JOIN hotels AS h ON r.hotel_id = h.id WHERE h.city_id = c.id AND t.id = at.trip_id)
    END AS `Trips`
FROM accounts AS a JOIN cities AS c ON a.city_id = c.id JOIN accounts_trips AS at ON a.id = at.account_id
HAVING `Trips` > 0
ORDER BY `Trips` DESC, a.id;
