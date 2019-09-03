USE `geography`;

#Problem 1
SELECT c.country_name, r.river_name
FROM (
SELECT c.country_name, cr.river_id, c.continent_code
FROM countries AS c JOIN countries_rivers AS cr
ON c.country_code=cr.country_code) AS c LEft JOIN rivers AS r
ON c.river_id=r.id
WHERE c.continent_code = 'AF'
ORDER BY c.country_name LIMIT 5;
