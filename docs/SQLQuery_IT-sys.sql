create database [IT-Support-System]

Create table Category(
	Id int not null identity(001,1) primary key,
	[Name] varchar(50) not null,
)

create table [Status](
	Id int not null identity(001,1) primary key,
	[Name] varchar(50) not null,
)

create table [Type](
	Id int not null identity(001,1) primary key,
	[Name] varchar(50) not null,
)

create table [User](
	Id int not null identity(001,1) primary key,
	FirstName varchar(50) not null,
	Surname varchar(50) not null,
	Email varchar(50) not null,
	[Password] varchar(50) not null,
	[TypeId] int foreign key references [Type](Id) not null
)

Create table Ticket(
	Id int not null identity(001,1) primary key,
	[Name] varchar(50) not null,
	[Description] varchar(255) not null,
	[Date] date not null,
	StatusId int foreign key references [Status](Id) not null,
	CategoryId int foreign key references [Category](Id) not null
)

select * from [user]