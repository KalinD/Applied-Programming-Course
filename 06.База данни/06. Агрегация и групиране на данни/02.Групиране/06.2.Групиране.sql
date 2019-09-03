USE `gringotts`;

#Problem 1
SELECT wd.deposit_group, MAX(wd.magic_wand_size) `longest_magic_wand` FROM wizzard_deposits AS wd
GROUP BY wd.deposit_group
ORDER BY MAX(wd.magic_wand_size), wd.deposit_group;

#Problem 2
SELECT wd.deposit_group FROM wizzard_deposits AS wd
GROUP BY wd.deposit_group ORDER BY AVG(wd.magic_wand_size) LIMIT 1;

#Problem 3
SELECT wd.deposit_group, SUM(wd.deposit_amount) `total_sum` FROM wizzard_deposits AS wd
GROUP BY wd.deposit_group ORDER BY SUM(wd.deposit_amount);