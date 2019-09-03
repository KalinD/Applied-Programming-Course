USE `soft_uni`;

#Problem 1
SELECT e.employee_id, e.job_title, e.address_id, a.address_text
FROM employees AS e JOIN addresses AS a ON e.address_id=a.address_id LIMIT 5;

#Problem 2
SELECT e.employee_id, e.first_name, e.last_name, d.name `department_name`
FROM employees AS e JOIN departments AS d ON e.department_id=d.department_id
WHERE d.name='Sales' ORDER BY e.employee_id DESC;

#Problem 3
SELECT e.employee_id, e.first_name, e.salary, d.name `department_name`
FROM employees AS e JOIN departments AS d ON e.department_id=d.department_id
WHERE e.salary > 15000 ORDER BY d.department_id DESC LIMIT 5;

#Problem 4
SELECT e.employee_id, e.first_name
FROM employees AS e
WHERE e.employee_id NOT IN (SELECT ep.employee_id FROM employees_projects AS ep)
ORDER BY e.employee_id DESC LIMIT 3;
 
#Problem 5
SELECT e.employee_id, e.first_name, e.manager_id, m.first_name `manager_name`
FROM employees AS e JOIN employees AS m ON e.manager_id=m.employee_id
WHERE e.manager_id IN (3, 7) ORDER BY e.first_name;

#Problem 6
SELECT e.salary, d.name
FROM (SELECT salary, department_id FROM employees ORDER BY salary LIMIT 1) AS e
JOIN departments AS d ON e.department_id=d.department_id; 

/* 
 * SELECT e.salary, d.name
 * FROM employees AS e JOIN departments AS d ON e.department_id=d.department_id
 * ORDER BY e.salary LIMIT 1;
 */
 
USE `geography`;
#Problem 7
SELECT c.country_name
FROM countries AS c WHERE c.country_code NOT IN (SELECT mc.country_code FROM mountains_countries AS mc);
/*#The count (should be 231)
 *SELECT COUNT(c.country_name)
 *FROM countries AS c WHERE c.country_code NOT IN (SELECT mc.country_code FROM mountains_countries AS mc);
*/
