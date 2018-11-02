CREATE DATABASE `many-to-many_connection`;
USE `many-to-many_connection`;

CREATE TABLE students(
	student_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50)
);

CREATE TABLE Exams(
	exam_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50)
);

ALTER TABLE exams AUTO_INCREMENT=101;

CREATE TABLE students_exams(
	student_id INT,
    exam_id INT,
    CONSTRAINT pk_students_exams PRIMARY KEY (student_id, exam_id),
    CONSTRAINT fk_students_exams_students_id FOREIGN KEY (student_id) REFERENCES students (student_id),
    CONSTRAINT fk_students_exams_exams_id FOREIGN KEY (exam_id) REFERENCES exams (exam_id)
);

INSERT INTO students (name) VALUES ("Mila"), ("Toni"), ("Ron");

INSERT INTO exams (name) VALUES ("Spring MVC"), ("Neo4j"), ("Oracle 11g");

INSERT INTO students_exams VALUES (1, 101),
(1, 102), (2, 101), (3, 103), (2, 102), (2, 103);

SELECT s.name "Student", e.name "Exam" FROM students AS s, exams AS e, students_exams AS se WHERE s.student_id=se.student_id AND e.exam_id=se.exam_id;