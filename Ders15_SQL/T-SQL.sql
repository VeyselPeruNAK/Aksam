USE Northwind;
GO -- Programlamadaki bloklar gibi.
DECLARE @sayi int; -- de�i�ken tan�mlad�k.  Sadece buradaki GO bloklar� i�inde ge�erli.
SET @sayi= 15; -- de�i�kene de�er atad�k.
-- PRINT @sayi; --  Normal yaz� olarak ekrana yazd�rd�k.
-- SELECT @sayi; -- Tablo olarak ekrana yazd�rd�k.
GO

GO
DECLARE @kategoriSayisi int;
--SELECT @kategoriSayisi =  COUNT(*) FROM Categories;  -- Count(*) sat�r say�s�n� getirir.
SELECT @kategoriSayisi =  COUNT(Categories.CategoryID) FROM Categories; -- yukar�daki ile ayn� i�i yapar.
PRINT @kategoriSayisi;
GO


PRINT GETDATE(); -- Tarih yazar.

DECLARE @sayi int;
SET @sayi= 10; -- tipi int.
PRINT CONVERT(NVARCHAR(5),@sayi)
PRINT CONVERT(NVARCHAR(3),123) -- 123 say�s�n� NVARCHAR'a �evir ekrana yaz.

PRINT TRY_CONVERT(NVARCHAR(3),1493) -- 1493 say�s�n� NVARCHAR'a �evirebilirse �evirir. �eviremezse hata vermez.

SELECT @sayi = CAST('34' AS INT) -- Castin ile tip d�n���m�
DECLARE @HECE NVARCHAR(20);
SELECT @HECE =RIGHT('mehmet',3) -- SA�DAK� 3 KARAKTER� AL.
PRINT @HECE; -- et

SELECT @HECE = LEFT('mehmet',3)  -- SOLDAK� 3 karakteri als�n.
PRINT @HECE;

SELECT @HECE = SUBSTRING('KADIK�Y',0,5);
PRINT @HECE;

PRINT REPLICATE('*',5) -- *'I 5 DEFA TEKRAR ET.


-- DATE FONKS�YONLARI
PRINT DATEDIFF(DD,'05.24.1993',GETDATE()) -- G�N OLARAK  -- G�N OLARAK FARK. MM YY DD
PRINT DATEDIFF(YY,'05.24.1993',GETDATE()) -- YIL OLARAK  -- G�N OLARAK FARK. MM YY DD
PRINT DATEDIFF(MM,'05.24.1993',GETDATE()) -- AY OLARAK  -- G�N OLARAK FARK. MM YY DD

PRINT CAST(DATEPART(DD,'09.09.1990') AS NVARCHAR(MAX)) + '.'+CONVERT(NVARCHAR(MAX),DATEPART(MM,'09.09.1990'))+'.'+ TRY_CONVERT(NVARCHAR(MAX),DATEPART(YYYY,'09.09.1990'))
-- TARIHIN PAR�ALARINI ALDIK.
PRINT DATENAME(MM,GETDATE()) -- AYIN ADI

PRINT DAY(GETDATE())
PRINT MONTH(GETDATE())
PRINT YEAR(GETDATE())
PRINT EOMONTH(GETDATE()) -- BU AYIN SON G�N�
PRINT CURRENT_TIMESTAMP --Jan  4 2020  9:18AM,   Dec  2 2021  2:15PM

PRINT UPPER('mehmet')-- b�y�t
PRINT LOWER('MEHMET')-- K���LT

PRINT ROUND(14.7,0) --15
PRINT ROUND(14.2,0) --14 0: VIRG�LDEN SONRA KA� KARAKTER OLACAK.


PRINT ASCII('V');
PRINT CHAR(86);
PRINT UNICODE('V');


PRINT CHARINDEX('K�Y','KADIK�Y'); --5

PRINT LTRIM('   BJK'); --BJK -- soldaki bo�luklar� siler.
PRINT RTRIM('BJK   '); --BJK

PRINT CONCAT('MEHMET ','DEM�R',99); --Birle�tirir.


DECLARE @ondalikli FLOAT
SET @ondalikli = 14.9939775;
PRINT STR(@ondalikli,7,2); -- tip d�n��t�rerek yazd�rd�k.

-- CASE


DECLARE @durum nvarchar(5);
SET @durum = 'evet2';
SELECT CASE @durum WHEN 'evet' THEN 'Durum Evet' else 'Durum evet de�il' END Durum; -- �art sa�lan�yorsa...

--- KO�UL KONTROL�

DECLARE @sayi2 int;
SET @sayi2=99;
IF(@sayi2<100)
BEGIN -- Blok ba�lang�c�
	PRINT 'sayi 100"den k���kt�r' 
END -- Blok biti�i
ELSE
BEGIN
	PRINT 'sayi 100 veya b�y�kt�r'
END

-- D�NG�LER


DECLARE @Sayac TINYINT
SET @Sayac=10
WHILE (@Sayac>0)
BEGIN
    PRINT @Sayac
    SELECT @Sayac=@Sayac-1
END


GO
	DECLARE @Sayac INT
	SET @Sayac=0
	WHILE (@Sayac<10) 
	BEGIN 
		SELECT @Sayac=@Sayac+1 
		IF(@Sayac*@Sayac>10)
			BEGIN
				PRINT 'Say�n�n karesi 10 de�erini ge�ti.'
				BREAK --d�ng�den c�k -- CONTINUE
			END
	END
GO

DECLARE @kategoriAdi nvarchar(max);
SELECT CategoryName , IIF(CategoryName='Beverages','Yiyecekler','��ecek') as Tip ,
IIF(CategoryName='Dairy Products','S�t �r�nleri','Di�er') as T�rk�e
FROM Categories;


IF EXISTS(SELECT * FROM Orders WHERE ShipCountry = 'France')
BEGIN
PRINT 'Fransa mevcuttur' 
END

PRINT @@MAX_CONNECTIONS 

PRINT @@LANGID

PRINT @@SERVERNAME

PRINT @@SERVICENAME

PRINT @@MICROSOFTVERSION

