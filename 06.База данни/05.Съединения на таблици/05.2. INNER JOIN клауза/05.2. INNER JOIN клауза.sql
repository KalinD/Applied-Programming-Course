USE `soft_uni`;

#Problem 1
SELECT e.first_name, e.last_name, at.name, at.address_text
FROM employees AS e JOIN
(SELECT a.address_id, a.address_text, t.name
FROM addresses AS a JOIN towns AS t ON a.town_id = t.town_id) AS at ON at.address_id=e.address_id
ORDER BY first_name, last_name LIMIT 5;

#Problem 2
SELECT DISTINCT e.first_name, e.last_name, e.hire_date, d.name `dept_name`
FROM employees AS e JOIN departments AS d ON d.department_id = e.department_id
WHERE d.name IN ('Finance', 'Sales') AND e.hire_date > '1999-01-01' 
ORDER BY e.hire_date;

#Problem 3
SELECT e.employee_id, e.first_name, p.name
FROM employees AS e JOIN (
SELECT ep.employee_id, p.name, p.start_date, p.end_date
FROM employees_projects AS ep JOIN projects AS p ON ep.project_id=p.project_id) AS p
ON e.employee_id=p.employee_id
WHERE p.start_date > '2002-8-13' AND p.end_date IS NULL
ORDER BY first_name, p.name LIMIT 5;

#Problem 4
SELECT e.employee_id, CONCAT(e.first_name, " ", e.last_name) `employee_name`, e.manager_name, d.name
FROM (
SELECT e.employee_id, e.first_name, e.last_name, CONCAT(m.first_name, " ", m.last_name) `manager_name`, e.department_id
FROM employees AS e JOIN employees AS m ON e.manager_id=m.employee_id) AS e
JOIN departments AS d ON e.department_id=d.department_id ORDER BY e.employee_id LIMIT 5;

USE `geography`;
#Problem 5
SELECT c.country_code, mp.mountain_range, mp.peak_name, mp.elevation
FROM (
SELECT c.country_code, mc.mountain_id
FROM countries AS c JOIN mountains_countries AS mc
ON c.country_code=mc.country_code) AS c JOIN (
SELECT m.id, m.mountain_range, p.peak_name, p.elevation
FROM mountains AS m JOIN peaks AS p ON m.id=p.mountain_id) AS mp
ON c.mountain_id=mp.id
WHERE c.country_code = 'BG' AND mp.elevation > 2835
ORDER BY mp.elevation DESC;

#Problem 6
SELECT c.country_code, c.country_name, m.mountain_range
FROM countries AS c JOIN (
SELECT mc.country_code, m.mountain_range
FROM mountains_countries AS mc JOIN mountains AS m
ON mc.mountain_id=m.id) AS m ON c.country_code=m.country_code
WHERE c.country_code IN ('BG', 'RU','US')
ORDER BY c.country_code, m.mountain_range;
