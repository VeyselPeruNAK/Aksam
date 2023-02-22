-- TRIGGER: Çaðýrýlmaksýzýn þartlar saðlandýðýnda otomatik çalýþan SQL
--          sorgularý yazmamýzý saðlar. þartlar saðlandýðýnda çalýþan sorgu bloklarý.
--          AFTER TRIGGER: Belirli bir sorgu çalýþrsa arkasýnda çalýþsýn þeklinde tanýmladýðýmýz
--                        TRIGGER yapýsýdýr. ÖRN: Categories tablosuna her INSERT yapýldýðýnda
--						  sorgusu otomatik çalýþsýn.
--			INSTEAD OF TRIGGER: Belirli bir tabloda çalýþan bir sorgu çaðýrýldýðýnda o sorgu 
--								çalýþmasýn bizim TRIGGER ile tanýmladýðýmýz sorgu çalýþsýn.

CREATE [ OR ALTER ] TRIGGER [ schema_name . ]trigger_name   
ON { table }   
[ WITH <dml_trigger_option> [ ,...n ] ]  
{AFTER | INSTEAD OF }   
{ [ INSERT ] [ , ] [ UPDATE ] [ , ] [ DELETE ] }  
 
AS { sql_statement   }

--CREATE TRIGGER TR_BlockDeleteCategory -- Trigger adýný belirttik.
--ON Northwind.dbo.Categories  -- Hangi tabloda çalýþacaðýný belirttik.
--INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda çalýþacaðýný belirttik.
--AS
--BEGIN
--	PRINT 'Bu tabloda silme iþlemi engellendi !!'
--END


ALTER TRIGGER TR_BlockDeleteCategory -- Trigger adýný belirttik.
ON Northwind.dbo.Categories  -- Hangi tabloda çalýþacaðýný belirttik.
INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda çalýþacaðýný belirttik.
AS
BEGIN
	DECLARE @catAdi NVARCHAR(50);	
	SELECT @catAdi = CategoryName FROM DELETED;  -- DELETED tablosu geçici(temp) olarak silinmeye çalýþan
	PRINT @catAdi+ ' silinmeye çalýþýldý.'
END

USE Northwind;
--SELECT * FROM Categories;
DELETE FROM Categories WHERE CategoryID=8; -- Seafood silinmeye çalýþýldý.
ENABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DISABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DELETE FROM Categories WHERE CategoryID=12;

SELECT * FROM Categories;
--

-- CategoriesBackup isimli bir tablo oluþturun. 
-- Categories tablosundan veri silinmeye çalýþýldýðýnda önce silinmeye çalýþýlan veriyi bu yeni tabloya 
-- insert edin.
-- Daha sonra silinmeye çalýþýlan satýrý silin.


------------------------
CREATE TABLE books_audit_table (
book_id INT NOT NULL IDENTITY PRIMARY KEY,
title VARCHAR(100)  NOT NULL,
author_name  VARCHAR(100),
genre VARCHAR(100),
updated_at DATETIME,
status VARCHAR(100)
);

INSERT INTO [practice_db].[dbo].[books_audit_table] ([title] ,[author_name] ,[genre] ,[updated_at] ,[status])
VALUES
('The Choice','Edith Eva Eger','Memoir',NULL, NULL),
('Deep Work','Carl Newport','Self Help',NULL, NULL),
('A Man Called Ove','Fredrik Backman','Fiction',NULL, NULL),
('When Breath Becomes Air','Paul Kalanithi','Memoir',NULL, NULL),
('Man Search for Meaning','Viktor Frankl','Memoir',NULL, NULL),
('The Third Pillar','Raghuram Rajan','Economics',NULL, NULL)
GO

CREATE TRIGGER update_trigger ON books_audit_table
AFTER UPDATE
AS
BEGIN
SET NOCOUNT ON; -- When you use SET NOCOUNT ON, the message that indicates the number of rows that are affected by the T-SQL                 --statement is not returned as part of the results. 
UPDATE books_audit_table set updated_at = GETDATE()
from books_audit_table b
INNER JOIN inserted i on b.book_id=i.book_id
AND i.status = 'Borrowed'
END
GO

UPDATE books_audit_table
SET Status='Borrowed'
WHERE book_id = 1;

