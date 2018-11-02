drop table if exists t_date;
CREATE TABLE t_date (
	c1 TIMESTAMP,
	c2 DATETIME
);

#SET time_zone='+00:00';
insert into t_date values (now(), now());

insert into t_date values ('2037-01-01 12:10:15', '2037-01-01 12:10:15');

insert into t_date values ('1970-01-01 00:00:01', '1970-01-01 00:00:01');

insert into t_date values ('2038-01-19 03:14:07', '1970-01-01 00:00:01');

insert into t_date values ('2039-01-01 12:10:15', '2039-01-01 12:10:15');

insert into t_date values ('1969-01-01 12:10:15', '1969-01-01 12:10:15');



#SET time_zone='+03:00';
select c1, c2 from t_date;