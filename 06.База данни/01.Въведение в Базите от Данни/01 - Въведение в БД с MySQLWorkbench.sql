CREATE DATABASE `school`;
USE `school`;

CREATE TABLE students(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    age INT NOT NULL,
    phone_number VARCHAR(10) NOT NULL    
);

CREATE TABLE classes(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    max_students INT NOT NULL    
);

CREATE TABLE teachers(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    class VARCHAR(50) NOT NULL    
);

CREATE TABLE towns(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);

INSERT INTO students (name, age, phone_number) VALUES ("Gosho", 17, "029212100");
INSERT INTO classes (name, max_students) VALUES ("APE", 30);
INSERT INTO teachers (name, class) VALUES ("Stela Stefanova", "APE");

SELECT * FROM students, classes, teachers;