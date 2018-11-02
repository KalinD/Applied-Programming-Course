CREATE DATABASE Minions;
USE Minions;

CREATE TABLE minions(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    age INT
);

CREATE TABLE towns(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);

ALTER TABLE minions ADD town_id INT;
ALTER TABLE minions ADD CONSTRAINT fk_town_id FOREIGN KEY (town_id) REFERENCES towns(id);

INSERT INTO towns (name) VALUES ("Sofia"), ("Plovdiv"), ("Varna");

INSERT INTO minions (name, age, town_id) VALUES("Kevin", 22, 1),
("Bob", 15, 3), ("Steward", NULL, 2);

TRUNCATE TABLE minions;

DROP TABLE minions, towns;

CREATE TABLE people(
	id INT NOT NULL AUTO_INCREMENT,
    CONSTRAINT pk_id PRIMARY KEY (id),
    name VARCHAR(200) NOT NULL,
    picture BLOB,
    height NUMERIC(10, 2),
    weight NUMERIC(10, 2),
    gender CHAR(1) NOT NULL,
    birthdate DATETIME NOT NULL,
    biography VARCHAR(10000)
);

INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES
('Kevin', NULL, 1.82, 82.24, 'm', '2001-02-01', 'Some biography here'),
('Marie Poppinz', NULL, 1.60, 40.55, 'f', '2001-03-01', 'Some biography here'),
('Steward', NULL, 1.84, 95.00, 'm', '2001-04-01', 'Some biography here'),
('Bob Bob', NULL, 1.86, 101.99, 'm', '2001-11-06', 'Some biography here'),
('An Ann Annie', NULL, 1.72, 60.22, 'f', '2001-12-01', 'Some biography here');

CREATE TABLE users(
	id INT NOT NULL AUTO_INCREMENT,
    CONSTRAINT pk_id PRIMARY KEY (id),
    username VARCHAR(30) NOT NULL,
    password VARCHAR(26) NOT NULL,
    profile_picture BLOB,
    last_login_time DATETIME,
    is_deleted INT
);

INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES
('pesho', '123456', NULL, NOW(), 0),
('gosho', '234567', NULL, NOW(), 0),
('mitko', '345678', NULL, NOW(), 1),
('cecko', '456789', NULL, NOW(), 0),
('bosko', '5678910', NULL, NOW(), 1);

ALTER TABLE users DROP PRIMARY KEY, ADD CONSTRAINT pk_users PRIMARY KEY (id, username);

ALTER TABLE users CHANGE COLUMN last_login_time last_login_time DATETIME NULL DEFAULT CURRENT_TIMESTAMP;

ALTER TABLE users DROP PRIMARY KEY, ADD CONSTRAINT pk_id PRIMARY KEY (id), ADD CONSTRAINT u_username UNIQUE (username);

CREATE DATABASE Movies;
USE Movies;

CREATE TABLE towns(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(200) NOT NULL
);

CREATE TABLE adresses(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    adress_text VARCHAR(10000) NOT NULL,
    town_id INT NOT NULL
);

CREATE TABLE departments(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(200) NOT NULL
);

CREATE TABLE employees(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(20) NOT NULL,
    middle_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    job_title  VARCHAR(200) NOT NULL,
    department_id INT NOT NULL,
    hire_date DATE,
    salary NUMERIC,
    address_id INT NOT NULL
);

/*•	towns (id, name)
•	addresses (id, address_text, town_id)
•	departments (id, name)
•	employees (id, first_name, middle_name, last_name, job_title, department_id, hire_date, salary, address_id)
*/