-- 1
create database store;

-- 2
create table items
(
	id int identity(1,1),
	name nvarchar(255) primary key,
	kind int not null,
	unit int not null,
	totalQuantity float not null,
	totalNumberOfSales float not null,
	totalGain float not null,
	profit float not null,
	salePrice float not null,
	itemDate date not null
);

create table itemDetails
(
	id int identity(1,1) primary key,
	billId int not null,
	itemId int not null,
	quantity float not null,
	buyPrice float not null,
	
);

create table bills
(
	id int identity(1,1),
	number int primary key,
	incName nvarchar(255),
	price float,
	billDate date,
	picture image
);

create table saleBills
(
	id int identity(1,1) primary key,
	customerName nvarchar(255),
	totalPrice float,
	billDate date,
	salesManName nvarchar(255),
	payMethod int
);
create table customerBalance
(
	id int identity(1,1) primary key,
	Name nvarchar(255),	
	totalAmount float
);
create table paymentHistory
(
	customerId int,
	operationDate date,
	billPrice float not null,
	payingAmount float not null,
	TotalDepit float not null
);
create table sales
(
	id int identity(1,1) primary key,
	billId int,
	itemId int,
	quantity float,
	unitName nvarchar(255),
	unitPrice float,
	totalPrice float,
	discount float
);
create table users
(
	name nvarchar(255),
	userName varchar(255) primary key,
	pass varchar(255),
	userRole varchar(255)
);
create table kinds
(
	id int,
	name nvarchar(255) primary key
);

create table units
(
	id int identity(1,1),
	name nvarchar(255) primary key
);
create table billReport
(	
	id int identity(1,1) primary key,
	billID int,
	name nvarchar(255),
	quantity float,
	unitName nvarchar(255),
	unitPrice float,
	discount float,
	totalUnitPrice float
);

create table billDetailsReport
(
	billID int,
	sallerName nvarchar(255),
	buyerName nvarchar(255),
	
	billTotalPrice float,
	totalDiscount float,
	
	paymentMethod nvarchar(255),
	payAmount float,
	
	finalBillAmount float,
	previousBalance float,
	currentBalance float
);
