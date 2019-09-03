#Игра на континенти
USE `geography`;

SELECT c.continent_name `FROM`, co.continent_name `TO`
FROM continents AS c CROSS JOIN continents AS co
ORDER BY c.continent_name, co.continent_name; 