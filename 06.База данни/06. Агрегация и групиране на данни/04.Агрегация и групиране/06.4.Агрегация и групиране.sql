USE `gringotts`;

#Problem 1
SELECT wd.deposit_group, wd.magic_wand_creator, MIN(wd.deposit_charge) `min_deposit_charge` FROM wizzard_deposits AS wd
GROUP BY wd.deposit_group, wd.magic_wand_creator ORDER BY wd.magic_wand_creator, wd.deposit_group;

#Problem 2
SELECT f.age_group, SUM(f.wizard_count) FROM
(SELECT CASE 
	WHEN wd.age < 10 THEN '[0-10]'
	WHEN wd.age >= 11 AND wd.age < 20 THEN '[11-20]'
	WHEN wd.age >= 21 AND wd.age < 30 THEN '[21-30]'
	WHEN wd.age >= 31 AND wd.age < 40 THEN '[31-40]'
	WHEN wd.age >= 41 AND wd.age < 50 THEN '[41-50]'
	WHEN wd.age >= 51 AND wd.age < 60 THEN '[51-60]'
    ELSE '[61+]'
END AS `age_group`, COUNT(*) AS `wizard_count`
FROM wizzard_deposits AS wd
GROUP BY wd.age) AS f GROUP BY f.age_group ORDER BY SUM(f.wizard_count);

#Problem 3
SELECT LEFT(wd.first_name, 1) `first_letter` FROM wizzard_deposits AS wd
WHERE wd.deposit_group = 'Troll Chest'
GROUP BY wd.first_name ORDER BY wd.first_name;

#Problem 4
SELECT wd.deposit_group, wd.is_deposit_expired, AVG(wd.deposit_interest) FROM wizzard_deposits AS wd
WHERE wd.deposit_start_date > '1985-01-01'
GROUP BY wd.deposit_group, wd.is_deposit_expired
ORDER BY wd.deposit_group DESC, wd.is_deposit_expired;