CREATE DATABASE `one-to-many_connection`;
USE `one-to-many_connection`;

CREATE TABLE manufacturers(
	manufacturer_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(10) NOT NULL,
    established_on DATE NOT NULL
);

CREATE TABLE models(
	model_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(10) NOT NULL,
    manufacturer_id INT,
    CONSTRAINT fk_manufacturer_id FOREIGN KEY (manufacturer_id) REFERENCES manufacturers (manufacturer_id)
);

ALTER TABLE models AUTO_INCREMENT=101;

INSERT INTO manufacturers (name, established_on) VALUES ("BMW", "1916-03-01"),
("Tesla", "2003-01-01"),
("Lada", "1966-05-01");

INSERT INTO models (name, manufacturer_id) VALUES("X1", 1),
("i6", 1), ("Model S", 2), ("Model X", 2), ("Model 3", 2),
("Nova", 3);
SELECT ma.name "Manufacturer name", ma.established_on "Manufacturer established on:", mo.name "Model name" FROM manufacturers AS ma JOIN models AS mo ON ma.manufacturer_id=mo.manufacturer_id;