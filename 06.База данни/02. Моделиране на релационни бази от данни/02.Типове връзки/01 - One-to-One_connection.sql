CREATE DATABASE `one-to-one_connection`;

USE `one-to-one_connection`;

CREATE TABLE passports(
	passport_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    passport_number VARCHAR(8) NOT NULL
);

CREATE TABLE Persons(
	person_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    Salary FLOAT NOT NULL,
    passport_id INT,
    CONSTRAINT fk_passport_id FOREIGN KEY (passport_id) REFERENCES passports(passport_id)
);

INSERT INTO passports VALUES (101, "N34FG21B"), (102, "K65LO4R7"), (103, "ZE657QP2");

INSERT INTO Persons VALUES (1, "Roberto", 43300.00, 102), (2, "Tom", 56100.00, 103), (3, "Yana", 60200.00, 101);

SELECT pe.person_id "Person ID", pe.first_name "Name", pe.Salary, pa.passport_number "Passport number" FROM persons AS pe JOIN passports AS pa ON pa.passport_id=pe.passport_id;