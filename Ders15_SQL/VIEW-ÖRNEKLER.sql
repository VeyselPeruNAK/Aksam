
--USE Northwind; -- Sorgu g�nderilen veritaban�n� Northwind yap.

-- Northwind veritaban�ndan �r�nler ve �r�n kategorilerini getiren INNER JOIN li sorguyu yaz�n�z.
-- Daha sonra ProductWithCategory isminde bir VIEW ile 
-- Products tablosundan ProductID,ProductName,SupplierID,UnitPrice,UnitsInStock ve 
-- Categories tablosundan CategoryName,Description kolonlar�n� listeleyiniz.

--CREATE VIEW ProductWithCategory AS
--	SELECT Products.ProductID,Products.ProductName,Products.SupplierID,Products.UnitPrice,
--	Products.UnitsInStock,Categories.CategoryName,Categories.Description
--	FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID;

-- SELECT * FROM ProductWithCategory;

-- Yukar�daki sorguya ek olarak Suppliers tablosundan CompanyName(Supplier) ve Phone(Supplier Phone) 
-- bilgisini getiecek �ekilde
-- P_CategorySupplier isminde bir VIEW tan�mlay�n�z.

--CREATE VIEW P_CategorySupplier AS
--	SELECT Products.ProductID,Products.ProductName,Products.SupplierID,Products.UnitPrice,
--	Products.UnitsInStock,Categories.CategoryName,Categories.Description,
--	Suppliers.CompanyName as 'Supplier', Suppliers.Phone as 'Supplier Phone'
--	FROM Products 
--	INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
--	INNER JOIN Suppliers  ON Products.SupplierID = Suppliers.SupplierID;

--SELECT * FROM P_CategorySupplier;

SELECT * FROM Orders;

-- Orders tablosunda OrderDate'i  1998 olanlar� d�nd�ren VIEW yaz�n�z.


 CREATE VIEW Orders1998 AS
 SELECT 
 Orders.OrderID,Orders.CustomerID,Orders.OrderDate ,
 CONCAT (Employees.FirstName,' ',Employees.LastName) AS Employee
 FROM Orders 
 INNER JOIN Employees
 ON Orders.EmployeeID=Employees.EmployeeID
 WHERE YEAR(Orders.OrderDate) = 1998-- LIKE('%1998%');

SELECT * FROM Orders1998;



--Orders tablosunda USA'a g�nderilen sipari�ler i�in: OrderID,CustomerID ve Employee Name ve Surname
-- Yukar�daki verileri VIEW olusturarak g�steriniz.

 CREATE VIEW OrdersUSA AS
 SELECT 
 Orders.OrderID,Orders.CustomerID,Orders.OrderDate ,Orders.ShipCountry,
 CONCAT (Employees.FirstName,' ',Employees.LastName) AS Employee
 FROM Orders 
 INNER JOIN Employees
 ON Orders.EmployeeID=Employees.EmployeeID
 WHERE Orders.ShipCountry='USA';

 SELECT * FROM OrdersUSA;



 SELECT * FROM Orders;
 SELECT * FROM [Order Details] WHERE OrderID=10248;
 SELECT (UnitPrice*Quantity) as TotalPrice FROM [Order Details] WHERE OrderID=10248;

 -- Almanya'ya yap�lan sat��lardan 200 dolardan fazla olanlar�n TotalPrice,CustomerID,ShipCity
 -- Bilgilerini yazd�ran VIEW tan�mlay�n�z.
 SELECT * FROM [Orders];
 SELECT * FROM [Order Details];

CREATE VIEW OrdersGermany200 AS
 SELECT  ([Order Details].UnitPrice*[Order Details].Quantity) as TotalPrice, Orders.CustomerID,Orders.ShipCity
 FROM Orders INNER JOIN [Order Details] ON Orders.OrderID= [Order Details].OrderID
 WHERE ([Order Details].UnitPrice*[Order Details].Quantity)>200 AND Orders.ShipCountry='Germany';


 SELECT * FROM OrdersGermany200;