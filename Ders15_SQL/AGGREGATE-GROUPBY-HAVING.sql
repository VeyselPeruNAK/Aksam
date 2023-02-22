USE [AdventureWorksLT2012]
SELECT COUNT(*) FROM SalesLT.Customer; -- Ka� m��teri var?
SELECT SUM(ListPrice) as ToplamTutar FROM SalesLT.Product;
-- Stoktaki �r�nlerin toplam tutar�

SELECT AVG(ListPrice) FROM SalesLT.Product; -- Ortalama Birim Fiyat�
SELECT MIN(ListPrice) FROM SalesLT.Product; -- En d���k Birim Fiyat�
SELECT MAX(ListPrice) FROM SalesLT.Product; -- En y�ksek Birim Fiyat�


-- GROUP BY --
USE [AdventureWorksLT2012]
SELECT Customer.CompanyName,Customer.[CustomerID] FROM SalesLT.Customer 
ORDER BY Customer.[CustomerID]; -- Ayr� ayr� listeledik.
-- Hangi sat�� temsilcisinin ka� m��terisi var?
SELECT COUNT(*) as M��teriSayisi,c.SalesPerson FROM SalesLT.Customer c 
GROUP BY c.SalesPerson;

-- 80 den fazla m��terisi olan sat�c� say�s�:
SELECT COUNT(*) as M��teriSayisi,c.SalesPerson 
FROM SalesLT.Customer c GROUP BY c.SalesPerson
HAVING COUNT(*) >80;

-- Products : Hangi kategoriden ka� �r�n var?
SELECT COUNT(p.ProductID)As Adet,ProductCategoryID FROM SalesLT.Product p
GROUP BY p.ProductCategoryID

SELECT c.ProductCategoryID, c.Name Kategori_Adi, COUNT(p.ProductID) Urun_Adedi
FROM SalesLT.Product p
INNER JOIN SalesLT.ProductCategory c ON p.ProductCategoryID = c.ProductCategoryID
GROUP BY c.ProductCategoryID, c.Name; 


-- Her kategorideki �r�nlerin toplam mal de�eri nedir?
SELECT SUM(p.ListPrice) as Toplam�r�nDe�eri,c.Name
FROM  SalesLT.Product p
JOIN SalesLT.ProductCategory c  ON p.ProductCategoryID=c.ProductCategoryID
GROUP BY c.Name;

USE [Northwind];
-- Her bir �r�nden ka� adet sipari� verilmi�?
SELECT * FROM [Order Details];
SELECT SUM([Order Details].Quantity),[Order Details].ProductID FROM [Order Details]
GROUP BY [Order Details].ProductID ORDER BY SUM([Order Details].Quantity) DESC;
-- Yukar�daki soruya ek olarak 1998 5. ay ve sonras�n�n sipari�lerini filtrelesin.

SELECT SUM([Order Details].Quantity),[Order Details].ProductID,Orders.OrderDate 
FROM [Order Details]
INNER JOIN Orders ON [Order Details].OrderID= Orders.OrderID
GROUP BY [Order Details].ProductID,Orders.OrderDate 
HAVING Orders.OrderDate >= '1998-05-01 00:00:00.000'
ORDER BY SUM([Order Details].Quantity) DESC;

USE [AdventureWorksLT2012]

SELECT COUNT(*) FROM SalesLT.Product 
WHERE ProductCategoryID IS NULL; -- CategoryID si NULL
-- olanlar� getir.

-- Her bir �r�nden ka� adet sipari� verilmi�?
USE NorthWind;
SELECT * FROM [Order Details];
SELECT SUM([Order Details].Quantity),[Order Details].ProductID FROM [Order Details]
GROUP BY [Order Details].ProductID ORDER BY SUM([Order Details].Quantity) DESC;

-- Yukar�daki sorguya ek olarak 1998 5. ay ve sonras�n�n sipari�lerini filtrelesin.
SELECT SUM([Order Details].Quantity) Toplam_Miktar,[Order Details].ProductID,Orders.OrderDate FROM [Order Details]
INNER JOIN Orders ON [Order Details].OrderID= Orders.OrderID
GROUP BY [Order Details].ProductID,Orders.OrderDate 
HAVING Orders.OrderDate >= '1998-05-01 00:00:00.000'
ORDER BY SUM([Order Details].Quantity) DESC;

--A�a��daki SQL Deyimi ise �Orders� tablosundan �CustomerID� = VINET'e 
--ait sipari�lerin say�s�n� bulur.
select * from orders
SELECT COUNT(CustomerID) AS OrdersFromCustomerID7 FROM Orders
WHERE CustomerID='VINET'



