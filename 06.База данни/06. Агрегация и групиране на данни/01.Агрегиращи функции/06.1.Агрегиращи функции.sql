USE `gringotts`;

#Problem 1
SELECT COUNT(wd.id) FROM wizzard_deposits AS wd;

#Problem 2
SELECT MAX(wd.magic_wand_size) `longest_magic_wand` FROM wizzard_deposits AS wd