drop table if exists t_doubles;

CREATE TABLE t_doubles (
	c1 FLOAT,
	c2 DOUBLE
);

insert into t_doubles (c1, c2) values (100.4, 70.6), (20.3, 50.1);

select sum(c1), sum(c2) from t_doubles;