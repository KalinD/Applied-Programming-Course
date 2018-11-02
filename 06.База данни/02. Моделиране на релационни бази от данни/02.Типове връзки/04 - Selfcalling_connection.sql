CREATE DATABASE `selfcalling_connection`;
USE `selfcalling_connection`;

CREATE TABLE teachers(
	teacher_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50),
    manager_id INT,
    CONSTRAINT fk_manager_id FOREIGN KEY (manager_id) REFERENCES teachers (teacher_id)
);

ALTER TABLE teachers AUTO_INCREMENT=101;

INSERT INTO teachers(name, manager_id) VALUES ("John", NULL),
("Maya", NULL), ("SIlvia", NULL), ("Ted", NULL), ("Mark", NULL), ("Greta", NULL);

UPDATE teachers SET manager_id = 105 WHERE teacher_id IN (104);
#UPDATE teachers SET manager_id = 105 WHERE teacher_id = 104;
UPDATE teachers SET manager_id = 101 WHERE teacher_id IN (105, 106);
#UPDATE teachers SET manager_id = 101 WHERE teacher_id = 105 OR 106;
UPDATE teachers SET manager_id = 106 WHERE teacher_id IN (102, 103);

SELECT * FROM teachers;