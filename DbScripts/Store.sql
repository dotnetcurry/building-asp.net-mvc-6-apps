Create database Store
Use Store

Create table Category(
 CategoryId int Identity Primary Key,
 CategoryName varchar(50) Not Null
)

Insert into Category values('Electronics');
Insert into Category values('Electrical');
Insert into Category values('Mechanical');

Create table Product
(
  ProductId int Identity Primary Key,
  ProductName varchar(50) Not Null,
  Price int Not Null,
  CategoryId int Not Null references Category(CategoryId) 
)


Insert into Product Values('Laptop',50000,1)
Insert into Product Values('Router',4600,1)
Insert into Product Values('Iron',500,2)
Insert into Product Values('Ceiling Fan',3000,2)
Insert into Product Values('Machine Toolkit',5000,3)
Insert into Product Values('Water Pully',5400,3)