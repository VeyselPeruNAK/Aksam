USE [AdventureWorksLT2012]
SELECT COUNT(*) FROM SalesLT.Customer; -- Kaç müþteri var?
SELECT SUM(ListPrice) as ToplamTutar FROM SalesLT.Product;
-- Stoktaki ürünlerin toplam tutarý

SELECT AVG(ListPrice) FROM SalesLT.Product; -- Ortalama Birim Fiyatý
SELECT MIN(ListPrice) FROM SalesLT.Product; -- En düþük Birim Fiyatý
SELECT MAX(ListPrice) FROM SalesLT.Product; -- En yüksek Birim Fiyatý


-- GROUP BY --
USE [AdventureWorksLT2012]
SELECT Customer.CompanyName,Customer.[CustomerID] FROM SalesLT.Customer 
ORDER BY Customer.[CustomerID]; -- Ayrý ayrý listeledik.
-- Hangi satýþ temsilcisinin kaç müþterisi var?
SELECT COUNT(*) as MüþteriSayisi,c.SalesPerson FROM SalesLT.Customer c 
GROUP BY c.SalesPerson;

-- 80 den fazla müþterisi olan satýcý sayýsý:
SELECT COUNT(*) as MüþteriSayisi,c.SalesPerson 
FROM SalesLT.Customer c GROUP BY c.SalesPerson
HAVING COUNT(*) >80;

-- Products : Hangi kategoriden kaç ürün var?
SELECT COUNT(p.ProductID)As Adet,ProductCategoryID FROM SalesLT.Product p
GROUP BY p.ProductCategoryID

SELECT c.ProductCategoryID, c.Name Kategori_Adi, COUNT(p.ProductID) Urun_Adedi
FROM SalesLT.Product p
INNER JOIN SalesLT.ProductCategory c ON p.ProductCategoryID = c.ProductCategoryID
GROUP BY c.ProductCategoryID, c.Name; 


-- Her kategorideki ürünlerin toplam mal deðeri nedir?
SELECT SUM(p.ListPrice) as ToplamÜrünDeðeri,c.Name
FROM  SalesLT.Product p
JOIN SalesLT.ProductCategory c  ON p.ProductCategoryID=c.ProductCategoryID
GROUP BY c.Name;

USE [Northwind];
-- Her bir üründen kaç adet sipariþ verilmiþ?
SELECT * FROM [Order Details];
SELECT SUM([Order Details].Quantity),[Order Details].ProductID FROM [Order Details]
GROUP BY [Order Details].ProductID ORDER BY SUM([Order Details].Quantity) DESC;
-- Yukarýdaki soruya ek olarak 1998 5. ay ve sonrasýnýn sipariþlerini filtrelesin.

SELECT SUM([Order Details].Quantity),[Order Details].ProductID,Orders.OrderDate 
FROM [Order Details]
INNER JOIN Orders ON [Order Details].OrderID= Orders.OrderID
GROUP BY [Order Details].ProductID,Orders.OrderDate 
HAVING Orders.OrderDate >= '1998-05-01 00:00:00.000'
ORDER BY SUM([Order Details].Quantity) DESC;

USE [AdventureWorksLT2012]

SELECT COUNT(*) FROM SalesLT.Product 
WHERE ProductCategoryID IS NULL; -- CategoryID si NULL
-- olanlarý getir.

-- Her bir üründen kaç adet sipariþ verilmiþ?
USE NorthWind;
SELECT * FROM [Order Details];
SELECT SUM([Order Details].Quantity),[Order Details].ProductID FROM [Order Details]
GROUP BY [Order Details].ProductID ORDER BY SUM([Order Details].Quantity) DESC;

-- Yukarýdaki sorguya ek olarak 1998 5. ay ve sonrasýnýn sipariþlerini filtrelesin.
SELECT SUM([Order Details].Quantity) Toplam_Miktar,[Order Details].ProductID,Orders.OrderDate FROM [Order Details]
INNER JOIN Orders ON [Order Details].OrderID= Orders.OrderID
GROUP BY [Order Details].ProductID,Orders.OrderDate 
HAVING Orders.OrderDate >= '1998-05-01 00:00:00.000'
ORDER BY SUM([Order Details].Quantity) DESC;

--Aþaðýdaki SQL Deyimi ise “Orders” tablosundan “CustomerID” = VINET'e 
--ait sipariþlerin sayýsýný bulur.
select * from orders
SELECT COUNT(CustomerID) AS OrdersFromCustomerID7 FROM Orders
WHERE CustomerID='VINET'



