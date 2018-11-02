drop table if exists t_text;
CREATE TABLE t_text (
	c1 VARCHAR(255) NULL DEFAULT NULL,
	c2 TINYTEXT NULL
);

insert into t_text values (REPEAT('д',255),REPEAT('д',255));

select c1, CHAR_LENGTH(c1), LENGTH(c1), c2, CHAR_LENGTH(c2), LENGTH(c2) from t_text;