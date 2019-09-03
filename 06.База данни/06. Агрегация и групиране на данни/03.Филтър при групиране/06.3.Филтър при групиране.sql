USE `gringotts`;

#Problem 1
SELECT wd.deposit_group, SUM(wd.deposit_amount) `total_sum`  FROM wizzard_deposits AS wd
WHERE wd.magic_wand_creator = 'Ollivander family'
GROUP BY wd.deposit_group ORDER BY wd.deposit_group;

#Problem 2
SELECT wd.deposit_group, SUM(wd.deposit_amount) `total_sum`  FROM wizzard_deposits AS wd
WHERE wd.magic_wand_creator = 'Ollivander family'
GROUP BY wd.deposit_group HAVING SUM(wd.deposit_amount) < 150000 ORDER BY SUM(wd.deposit_amount) DESC;
