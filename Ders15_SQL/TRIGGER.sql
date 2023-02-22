-- TRIGGER: �a��r�lmaks�z�n �artlar sa�land���nda otomatik �al��an SQL
--          sorgular� yazmam�z� sa�lar. �artlar sa�land���nda �al��an sorgu bloklar�.
--          AFTER TRIGGER: Belirli bir sorgu �al��rsa arkas�nda �al��s�n �eklinde tan�mlad���m�z
--                        TRIGGER yap�s�d�r. �RN: Categories tablosuna her INSERT yap�ld���nda
--						  sorgusu otomatik �al��s�n.
--			INSTEAD OF TRIGGER: Belirli bir tabloda �al��an bir sorgu �a��r�ld���nda o sorgu 
--								�al��mas�n bizim TRIGGER ile tan�mlad���m�z sorgu �al��s�n.

CREATE [ OR ALTER ] TRIGGER [ schema_name . ]trigger_name   
ON { table }   
[ WITH <dml_trigger_option> [ ,...n ] ]  
{AFTER | INSTEAD OF }   
{ [ INSERT ] [ , ] [ UPDATE ] [ , ] [ DELETE ] }  
 
AS { sql_statement   }

--CREATE TRIGGER TR_BlockDeleteCategory -- Trigger ad�n� belirttik.
--ON Northwind.dbo.Categories  -- Hangi tabloda �al��aca��n� belirttik.
--INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda �al��aca��n� belirttik.
--AS
--BEGIN
--	PRINT 'Bu tabloda silme i�lemi engellendi !!'
--END


ALTER TRIGGER TR_BlockDeleteCategory -- Trigger ad�n� belirttik.
ON Northwind.dbo.Categories  -- Hangi tabloda �al��aca��n� belirttik.
INSTEAD OF DELETE  -- Trigger tipini ve hangi sorguda �al��aca��n� belirttik.
AS
BEGIN
	DECLARE @catAdi NVARCHAR(50);	
	SELECT @catAdi = CategoryName FROM DELETED;  -- DELETED tablosu ge�ici(temp) olarak silinmeye �al��an
	PRINT @catAdi+ ' silinmeye �al���ld�.'
END

USE Northwind;
--SELECT * FROM Categories;
DELETE FROM Categories WHERE CategoryID=8; -- Seafood silinmeye �al���ld�.
ENABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DISABLE TRIGGER TR_BlockDeleteCategory ON Northwind.dbo.Categories;
DELETE FROM Categories WHERE CategoryID=12;

SELECT * FROM Categories;
--

-- CategoriesBackup isimli bir tablo olu�turun. 
-- Categories tablosundan veri silinmeye �al���ld���nda �nce silinmeye �al���lan veriyi bu yeni tabloya 
-- insert edin.
-- Daha sonra silinmeye �al���lan sat�r� silin.


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

