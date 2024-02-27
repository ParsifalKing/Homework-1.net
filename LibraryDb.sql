create table Books
(
    Id serial primary key,
	Title varchar(100),
	Author varchar(150),
	Category varchar(150),
	Access bool
);

select * from Books
