USE [Northwind]
GO

/****** Object:  Table [dbo].[Categories]    Script Date: 6.12.2021 14:07:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CategoriesBackup](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL
	)
GO




ALTER trigger TR_Yedekleme2
on Northwind.dbo.Categories
instead of delete
as
begin
	DECLARE @id int;
	DECLARE @name nvarchar(15);
	DECLARE @desc nvarchar(max);
	DECLARE @img VARBINARY(MAX);
	SELECT @id = CategoryID FROM DELETED;
	SELECT @name = CategoryName FROM DELETED;
	SELECT @desc = Description FROM DELETED;
	SELECT @img = Picture FROM DELETED;

	INSERT INTO CategoriesBackup (CategoryID,CategoryName,Description,Picture)
	VALUES(@id,@name,@desc,@img);
	DELETE FROM Categories WHERE CategoryID=@id;
end

DELETE FROM Categories WHERE CategoryID=11;

SELECT * FROM Categories;
SELECT * FROM CategoriesBackup;


-- 2. Y�NTEM


ALTER TRIGGER TR_BackUp --Trigger ad� tan�mland�
ON Northwind.dbo.Categories -- �al��aca��m�z tablo belirlendi
INSTEAD OF DELETE --Trigger tipi ve hangi sorguda �al��aca��n� belirttik
AS
BEGIN
	INSERT INTO CategoriesBackUp(CategoryID, CategoryName, Description, Picture)
	SELECT CategoryID, CategoryName, Description, Picture
	FROM deleted;
	DECLARE @id INT;
	SELECT @id = CategoryID from deleted
	DELETE FROM Categories WHERE CategoryID = @id;
END

