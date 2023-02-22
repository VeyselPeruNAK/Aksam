--Stored Procedure: SQL dilinde yaz�l�mdaki metotlara kar��l�k gelen ifadedir.
--					SP k�saltmas� ile bilinir. Parametreli veya parametresiz olabilir.
--					Ald��� parametreleri sorgularda kullanabilir.
--					Geriye de�er d�nd�rebilir.(OUTPUT)
--					Belirli i�leri yapan sorgular� SP ler ile 1 defa yazarak s�rekli kullan�r�z.


--STORED PROCEDURE TANIMLANMASI

--CREATE PROCEDURE sp_GetirKategori -- CREATE PROC da kullanl�abilir.
--AS
--BEGIN
--SELECT * FROM Northwind.dbo.Categories;
--END


-- STORED PROCEDURE KULLANIMI
-- EXECUTE Northwind.dbo.sp_GetirKategori;
--EXECUTE sp_GetirKategori;  -- EXEC sp_GetirKategori;

--ALTER PROC sp_AraKategori(@name NVARCHAR(50)) AS
--BEGIN
--	DECLARE @sayi  INT;
--	SELECT @sayi = COUNT(*) FROM Northwind.dbo.Categories WHERE Categories.CategoryName = @name;
--	IF (@sayi>0)
--		BEGIN
--			SELECT * FROM Northwind.dbo.Categories WHERE Categories.CategoryName = @name;
--			SELECT STR(@sayi) + ' adet kay�t bulundu.'
--		END
--	ELSE
--		BEGIN
--			PRINT 'Herhangi bir kay�t bulunamad�!'
--		END
--END

--EXEC Northwind.dbo.sp_AraKategori 'Elma';
EXECUTE Northwind.dbo.sp_AraKategori 'Beverages';

-- Order Details tablosundan unit price ve quantity alt s�n�r�na g�re sorgu �ekecek SP yi yaz�n�z.
-- �rnek : EXEC GetOrderDetails 10,15; -- UnitPrice 10 ve �zeri Quantity 15 ve �zeri olanlar� getir.


--CREATE PROC sp_GetirSipDetay
--(
--	@unitPriceLimit INT,@quantityLimit INT
--)
--AS
--BEGIN
--	SELECT * FROM [Order Details] WHERE [Order Details].UnitPrice>=@unitPriceLimit AND [Order Details].Quantity>=@quantityLimit;
--END



--EXECUTE sp_GetirSipDetay 10,5;


-- Categories tablosuna kay�t eklemesi yapan SP yi yaz�n�z.
-- Parametreler name,desc,pict

--CREATE PROCEDURE SP_AddCategory 
--(
--	@name NVARCHAR(50),@desc NVARCHAR(max),@pict IMAGE
--)
--AS
--BEGIN
--	INSERT INTO Northwind.dbo.Categories (CategoryName,Description,Picture)
--	VALUES (@name,@desc,@pict);
--END

--EXEC SP_AddCategory 'Technology','Tecnology devices like computers,cameras...','foto.png';

--SELECT * FROM Categories;


-- Categories tablosundan silme i�lemi yapan SP yi yaz�n�z.
-- parametre olarak ID als�n.

--CREATE PROC sp_SilKategori (@ID INT) AS
--BEGIN
--	SELECT * FROM Northwind.dbo.Categories;
--	DELETE FROM Northwind.dbo.Categories WHERE CategoryID = @ID;
--	SELECT * FROM Northwind.dbo.Categories;
--END


--EXEC sp_SilKategori 9;

-- Categories tablosundaki kay�tlar� update etmemizi sa�layan SP yi yaz�n�z.


--ALTER PROC sp_GuncelleKategori 
--(@ID INT,@name NVARCHAR(50),@desc NVARCHAR(50),@pict IMAGE) AS
--BEGIN
--	UPDATE Categories SET CategoryName=@name,Description=@desc,Picture=@pict WHERE CategoryID=@ID;
--	SELECT 'Etiklenen sat�r say�s�: '+STR(@@ROWCOUNT);
--END

--EXEC sp_GuncelleKategori 12,'Sports','Sport products like basketball shoes...','Test';



--SELECT * FROM Categories;
--EXEC SP_AddCategory 'ASD','ASD','ASD';
--GO
--UPDATE Categories SET CategoryName='Test',Description='Test',Picture='Test' WHERE CategoryID=12;
--SELECT @@ROWCOUNT
--GO


-- Ka� kategori oldu�unu d�nd�ren SP yi yaz�n�z.

--CREATE PROCEDURE SP_GetCategoryCount (@count INT OUTPUT) AS
--BEGIN
--	SELECT @count = COUNT(*) FROM Categories;
--END


DECLARE @sayi INT; -- Bo� de�i�ken tan�mlad�k.
EXECUTE SP_GetCategoryCount @sayi OUTPUT; -- SP den gelen de�eri @sayi de�i�kenine atad�k.
PRINT 'Categories tablosundaki kay�t say�s� : '+STR(@sayi);

-- Kendisine g�nderilen 2 adet say�y� toplay�p sonucu d�nd�ren Sp yi yaz�n�z.
--Kendisine g�nderilen 2 adet say�y� toplay�p sonucu d�nd�ren sp ;
CREATE PROC sp_topla (@say�1 int, @say�2 int, @sonuc int output) AS
BEGIN
	SET @sonuc = @say�1+@say�2;
END
-- SP yi �a��r�rken.

DECLARE @sonuc INT;
EXECUTE topla 3,4,@sonuc OUTPUT;
PRINT 'Toplama sonucu : '+STR(@sonuc);













