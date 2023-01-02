
drop table if exists Product
create table Product
(
	Id int identity(1,1) not null,
	ProductName nvarchar(max) not null,
	Description nvarchar(max),
	Price decimal(18,6) default 0
)


drop table if exists Login
create table login
(
	Id int identity(1,1) not null,
	Username nvarchar(max) not null,
	Password nvarchar(max) not null
)