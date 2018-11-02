drop table if exists t_enum_set;
CREATE TABLE t_enum_set (
	c1 enum('a', 'b', 'c'),
	c2 set('a', 'b', 'c')
);

insert into t_enum_set (c1, c2) values ('a', 'a');
insert into t_enum_set (c1, c2) values ('b', 'b');
insert into t_enum_set (c1, c2) values ('c', 'c');

insert into t_enum_set (c1, c2) values ('a,b', 'a,b');
insert into t_enum_set (c1, c2) values ('a,c,b', 'a,c,b');

insert into t_enum_set (c1, c2) values ('d', 'a,d,e');

select c1, c2 from t_enum_set;
