--create database [IT-Support-System]

create table [User](
	Id int not null identity(001,1) primary key,
	FirstName varchar(50) not null,
	Surname varchar(50) not null,
	Email varchar(50) not null,
	[Password] varchar(50) not null,
	[Type] varchar(20) not null
)

Create table Category(
	Id int not null identity(001,1) primary key,
	[Name] varchar(50) not null,
)

create table [Status](
	Id int not null identity(001,1) primary key,
	[Name] varchar(50) not null,
)

Create table Ticket(
	Id int not null identity(001,1) primary key,
	[Name] varchar(50) not null,
	[Description] varchar(255) not null,
	[Date] date not null,
	StatusId int foreign key references [Status](Id) not null,
	CategoryId int foreign key references [Category](Id) not null
)