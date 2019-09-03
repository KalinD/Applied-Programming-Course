CREATE DATABASE `ruk_database`;
USE `ruk_database`;

#Problem 1
CREATE TABLE branches(
	id INT(11) PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE employees(
	id INT(11) PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    salary NUMERIC(10, 2) NOT NULL,
    started_on DATE  NOT NULL,
    branch_id INT(11) NOT NULL,
    CONSTRAINT fk_employees_branches FOREIGN KEY (branch_id) REFERENCES branches(id)
);

CREATE TABLE clients(
	id INT(11) PRIMARY KEY AUTO_INCREMENT,
    full_name VARCHAR(50) NOT NULL,
    age INT(11) NOT NULL
);

CREATE TABLE employees_clients(
	employee_id INT(11),
    client_id INT(11),
    CONSTRAINT fk_employees_clients_employess FOREIGN KEY (employee_id) REFERENCES employees (id),
    CONSTRAINT fk_employees_clients_clients FOREIGN KEY (client_id) REFERENCES clients (id)
);

CREATE TABLE bank_accounts(
	id INT(11) PRIMARY KEY AUTO_INCREMENT,
    account_number VARCHAR(10) NOT NULL,
    balance NUMERIC(10, 2) NOT NULL,
    client_id INT(11) NOT NULL UNIQUE,
    CONSTRAINT fk_bank_accounts_clients FOREIGN KEY (client_id) REFERENCES clients (id)    
);

CREATE TABLE cards(
	id INT(11) PRIMARY KEY AUTO_INCREMENT,
    card_number VARCHAR(19) NOT NULL,
    card_status VARCHAR(7) NOT NULL,
    bank_account_id INT(11) NOT NULL,
    CONSTRAINT fk_cards_bank_accounts FOREIGN KEY (bank_account_id) REFERENCES bank_accounts (id)
);

#Problem 2
INSERT INTO clients (full_name, age) VALUES('Hunter Smith', 30),
('Peter Nikolov', 25),
('Maia Stones', 40),
('William Terry', 60);

#Problem 3
UPDATE clients
SET age = 
CASE
	WHEN id % 2 = 0 THEN age + 5
    ELSE age
END
WHERE id > 0;

/*
UPDATE clients
SET age = age + 5
WHERE id % 2 = 0;
*/

#Problem 4
DELETE FROM clients
WHERE id % 2 != 0;

#Problem 5
SELECT c.id, c.full_name FROM clients AS c ORDER BY c.id;

#Problem 6
SELECT
	e.id,
	CONCAT(e.first_name, ' ', e.last_name) AS `full_name`,
    CONCAT('$', e.salary) AS `salary`, e.started_on
FROM employees AS e WHERE e.salary >= 100000 AND e.started_on >= '2018-01-01'
ORDER BY e.salary DESC;

#Problem 7
SELECT ca.id, CONCAT(ca.card_number, ':', cl.full_name)
FROM cards AS ca JOIN bank_accounts AS ba ON ca.bank_account_id = ba.id JOIN clients AS cl
ON ba.client_id = cl.id ORDER BY ca.id DESC;

#Без да join-вам cards!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
#Problem 8
SELECT
	ba.id,
    ba.account_number,
    CONCAT('$', ba.balance) AS `name`,
    cl.full_name
FROM bank_accounts AS ba
JOIN clients AS cl ON ba.client_id = cl.id
JOIN cards AS ca ON ca.bank_account_id = ba.id
GROUP BY ba.id, ba.account_number, ba.balance, cl.full_name
HAVING MIN(ca.card_status) IN ('Frozen', 'Deleted')
ORDER BY ba.id DESC;

#Problem 9
SELECT
	CONCAT(e.first_name, ' ', e.last_name) AS `name`,
	e.started_on,
    (SELECT COUNT(*) FROM clients AS c JOIN employees_clients AS ec On c.id = ec.client_id WHERE ec.employee_id = e.id) AS `count_of_clients`
FROM employees AS e ORDER BY `count_of_clients` DESC, e.id LIMIT 5;

#Problem 10
SELECT
	cl.id,
    cl.full_name,
    (SELECT COUNT(*) FROM cards AS ca JOIN bank_accounts AS ba ON ca.bank_account_id = ba.id WHERE ba.client_id = cl.id) AS `cards`
FROM clients AS cl ORDER BY `cards` DESC, cl.id LIMIT 1;

#Problem 11
SELECT
	b.name AS `id`,
    COUNT(ec.client_id) AS `clients`
FROM branches AS b INNER JOIN employees AS e ON b.id = e.branch_id INNER JOIN employees_clients AS ec
ON e.id = ec.employee_id
GROUP BY b.name ORDER BY COUNT(ec.client_id) DESC, b.id;


