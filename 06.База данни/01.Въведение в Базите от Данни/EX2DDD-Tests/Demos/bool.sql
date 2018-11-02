drop table if exists t_boolean;
CREATE TABLE t_boolean (
	c1 bool,
	c2 bit,
	c3 tinyint(1)
);

insert into t_boolean (c1, c2, c3) values (true, 0, '9');
insert into t_boolean (c1, c2, c3) values (false, 0, '9');

select c1, c2, c3 from t_boolean;
