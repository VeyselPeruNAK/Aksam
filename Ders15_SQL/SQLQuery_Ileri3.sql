-- CustomerID'si ANTON olan kaydýn ContactName'ini 'Alfred Schmidt' ve City'sini 'Frankfurt' yapýnýz. 

UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 'ANTON';

SELECT * FROM Customers
WHERE CustomerID = 'ANTON';

-- Country'si 'Mexico'olan kayýtlarýn ContactName'ini 'Juan' Yap!
UPDATE Customers
SET ContactName='Juan'
WHERE Country='Mexico';

--Be careful when updating records. If you omit the WHERE clause, ALL records will be updated!

--DELETE FROM table_name WHERE condition;

--Note: Be careful when deleting records in a table! Notice the WHERE clause in the DELETE statement. 
--The WHERE clause specifies which record(s) should be deleted. 
--If you omit the WHERE clause, all records in the table will be deleted!

begin transaction
ROLLBACK

select * FROM Customers WHERE ContactName='Juan';

DELETE FROM Customers WHERE ContactName='Juan';

SELECT * FROM Orders WHERE CustomerID IN(
SELECT CustomerID FROM Customers  WHERE ContactName='Juan')

DELETE FROM Orders WHERE CustomerID IN(
SELECT CustomerID FROM Customers  WHERE ContactName='Juan')

SELECT * FROM [Order Details] WHERE OrderID IN 
(SELECT OrderID FROM Orders WHERE CustomerID IN(
SELECT CustomerID FROM Customers  WHERE ContactName='Juan'))

DELETE FROM [Order Details] WHERE OrderID IN 
(SELECT OrderID FROM Orders WHERE CustomerID IN(
SELECT CustomerID FROM Customers  WHERE ContactName='Juan'))

DELETE FROM Orders WHERE CustomerID IN(
SELECT CustomerID FROM Customers  WHERE ContactName='Juan')

--The following SQL statement selects all the orders from the customer with CustomerID=4 ('Giovanni Rovelli'). 
--We use the "Customers" and "Orders" tables, and give them the table aliases of "c" and "o" respectively 
--(Here we use aliases to make the SQL shorter):
SELECT o.OrderID, o.OrderDate, c.ContactName
FROM Customers AS c, Orders AS o
WHERE c.ContactName='Giovanni Rovelli' AND c.CustomerID=o.CustomerID;

--The GROUP BY statement groups rows that have the same values into summary rows, like "find the number of customers in each country".
--The GROUP BY statement is often used with aggregate functions (COUNT(), MAX(), MIN(), SUM(), AVG()) to group the result-set by one or more columns.

/*
SELECT column_name(s)
FROM table_name
WHERE condition
GROUP BY column_name(s)
ORDER BY column_name(s);
*/

--number of customers in each country:
SELECT Country, COUNT(CustomerID)
FROM Customers
GROUP BY Country;

--The following SQL statement lists the number of customers in each country, sorted high to low:

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC;

--lists the number of orders sent by each shippe
SELECT Shippers.CompanyName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
GROUP BY  Shippers.CompanyName
ORDER BY 1;

/*
SELECT column_name(s)
FROM table_name
WHERE condition
GROUP BY column_name(s)
HAVING condition
ORDER BY column_name(s);
*/

--lists the number of customers in each country. Only include countries with more than 5 customers
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5;  -- <5

--lists the number of customers in each country, sorted high to low 
--(Only include countries with more than 5 customers):
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5
ORDER BY COUNT(CustomerID) DESC;

-- ShipCountry baþýna 50'den az sipariþ(Orders) gelen ülkeleri, 
-- sipariþ adedine göre büyükten küçüðe sýralayýp yazan query.
SELECT COUNT(OrderID), ShipCountry
FROM Orders
GROUP BY ShipCountry
HAVING COUNT(ORDERID) < 50
ORDER BY COUNT(OrderID) DESC;

--INSERT INTO SELECT

/*
--Copy all columns from one table to another table:

INSERT INTO table2
SELECT * FROM table1
WHERE condition;

--Copy only some columns from one table into another table:

INSERT INTO table2 (column1, column2, column3, ...)
SELECT column1, column2, column3, ...
FROM table1
WHERE condition;
*/

--The following SQL statement copies "Suppliers" into "Customers" 
--(the columns that are not filled with data, will contain NULL):
-- Contactname'i 40 yap!!! 
begin transaction
INSERT INTO Customers (CustomerID,ContactName,CompanyName, City, Country)
SELECT SupplierID,CompanyName, CompanyName, City, Country FROM Suppliers;
ROLLBACK



/*
CASE
    WHEN condition1 THEN result1
    WHEN condition2 THEN result2
    WHEN conditionN THEN resultN
    ELSE result
END;
*/

SELECT OrderID, Quantity,
CASE
    WHEN Quantity > 30 THEN 'The quantity is greater than 30'
    WHEN Quantity = 30 THEN 'The quantity is 30'
    ELSE 'The quantity is under 30'
END AS QuantityText
FROM [Order Details];

--The following SQL will order the customers by City. 
--However, if City is NULL, then order by Country:


SELECT ContactName, City, Country, 
    CASE WHEN City IS NULL THEN Country
    ELSE City
END AS [Þehir]
FROM Customers

--Customers ta kaç tekil Country var
SELECT COUNT(DISTINCT Country) FROM Customers;

SELECT * FROM Customers
WHERE Country='Germany' AND (City='Berlin' OR City='München');

SELECT ContactName, Address
FROM Customers
WHERE Address IS  NULL;

SELECT * FROM Customers
WHERE Country IN ('Germany', 'France', 'UK');

SELECT City, Country FROM Customers
WHERE Country='Germany'
UNION ALL
SELECT City, Country FROM Suppliers
WHERE Country='Germany'
ORDER BY City;

--Shippers.CompanyName bazýnda sipariþ sayýlarý
SELECT Shippers.CompanyName,COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
LEFT JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
GROUP BY CompanyName;

-- Customers2'yi oluþtur, sonrasýnda
INSERT INTO Customers2
SELECT * FROM Customers

--truncate table Customers2

select * from dbo.Customers2

-- Foreign key oluþturma.
CREATE TABLE Orders (
    OrderID int NOT NULL PRIMARY KEY,
    OrderNumber int NOT NULL,
    PersonID int FOREIGN KEY REFERENCES Persons(PersonID)
);

-- FOREIGN KEY oluþturma:
ALTER TABLE Orders
ADD FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID);
-- CREATE TABLE
CREATE TABLE Persons (
    PersonID int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int
);

--CREATE INDEX Syntax
--Creates an index on a table. Duplicate values are allowed:
/*
CREATE INDEX index_name
ON table_name (column1, column2, ...);*/
--CREATE UNIQUE INDEX Syntax
--Creates a unique index on a table. Duplicate values are not allowed:
/*
CREATE UNIQUE INDEX index_name
ON table_name (column1, column2, ...);
*/

--DROP INDEX table_name.index_name;

--C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\



set Concat_Null_Yields_Null OFF
SELECT CompanyName, Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS Address
FROM Customers;
set Concat_Null_Yields_Null off  -- ON Olunca NULL'lar geliyor.

SELECT GetDate() 'GetDate',FORMAT(GetDate() , 'd', 'tr-TR') AS Turkce,
FORMAT(GetDate() , 'd', 'en-US') AS Amerikan,
FORMAT(GetDate() , 'd', 'en-gb') AS Ingiliz;

-- INNER JOIN
SELECT Orders.OrderID, Customers.ContactName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;



