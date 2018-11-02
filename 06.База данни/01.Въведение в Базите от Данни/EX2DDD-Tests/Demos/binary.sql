drop table if exists t_binary;
CREATE TABLE t_binary (
	c1 VARBINARY(255),
	c2 BINARY(5),
	c3 char(5)
);

insert into t_binary (c1, c2, c3) values ('aaa', 'aaa', 'aaa');

select c1 = 'aaa', c2='aaa', c3='aaa' from t_binary;
