--RDBMS (Relational Database Management Systems)
--�li�kisel Veritaban� Y�netim Sistemleri
--SQL Server: D�nya'da bireysel ve kurumsal en �ok tercih
--edilen, d���k maliyetli, y�ksek performansl�, Windows
--i�letim sistemi �zerinde �al��an, SQL standard�n�
--destekleyen, kendine �zg� T-SQL sorgu diline sahip,
--geli�mi� bir �li�kisel Veritaban� Y�netim Sistemidir.
 
--Ba�ka �rnek RDBMS: Oracle, DB2, MySql, PostgreSQL

--Transact-SQL = T-SQL

--VER�TABANI NESNELER�:
--Database Table Index Diagram View User Stored Procedure
--Function Trigger vb.

--Database nesnesi: Di�er nesnelerin bir �o�u DB nesnesinin
--elemanlar�d�r. DB'ler table index diagram view User 
--Stored Procedure gibi bir �ok nesneyi i�inde bar�nd�r�r.

--Master Veritaban�: Sistemin b�t�n�n� izlemeye yarar, 
--sistem tablolar� k�mesini i�ine al�r.
SELECT * from SYS.databases 
EXEC sp_who

--Diagramlar: Tablolar�n ili�kilendirilmelerini g�steren
--ve y�netebilece�imiz bir VT g�rselle�tirme arac�d�r.

--�emalar: DB i�indeki nesnelerin mant�ksal isimlendirmesini
--yapar. 
--dbo �emas�: Database Owner(VT sahibi) demektir, varsay�lan
--�emad�r.
SELECT * from tb_ogrenci

--Tablolar: DB'nin en temel yap�s�d�r. Sat�r ve s�tunlardan 
--olu�ur. Alan veri(s�tunlar), alan olu�turmak ve bu 
--alanlara yaz�lacak verinin tipini belirtmeye yarar.
--Kay�t veri(sat�rlar), alanlara veri girilmesiyle olu�ur.

--Index'ler: Tablo ve viewlar i�in bulunan bir nesnedir.
--Index, s�ralama i�lemini daha disiplinli yaparak 
--performans art�rmay� ve h�zl� sorgu sonucu d�nd�rmeyi
--ama�lar. 

--Constraint(K�s�tlamalar): Tablolar i�inde veri 
--b�t�nl���n� sa�lamay� ama�lar.

--View'lar(G�r�n�m): View bir ya da birden fazla tablonun
--sanal g�r�nt�s�d�r. Kullan�m nedenleri:G�venlik, 
--performans ve kullan�m kolayl���d�r. 

--Stored Procedures(Sakl� Yordamlar): Stored Procedures
--di�er ad�yla sproc'lar SQL Server programlama(T-SQL)
--alt yap�s�n�n en �nemli ve �ok kullan�lan 
--�zelliklerinden birisidir. Sproc'lar VT'de yap�lacak
--i�lemlerin bir program d�zeninde ger�ekle�mesini 
--sa�layan T-SQL programc�klar�d�r. De�i�kenler, 
--girdi-��kt� parametreleri, klasik SQL sorgular� 
--gibi bir�ok �zelli�i kullan�r. G�venlik, performans ve
--h�zl� i�lem ger�ekle�tirebilme gibi bir �ok faydaya
--sahiptir. �� i�e de kullan�labilir.

--Triggers(Tetikleyiciler): Tablolar �zerinde ekleme,
--g�ncelleme, silme ve kopyalama gibi i�lemlerin 
--ger�ekle�meden �nce veya sonra yap�lmas� gereken
--i�lemlerin otomatik olarak ger�ekle�mesini sa�layan
--T-SQL programc�klar�d�r. 

--T-SQL Transact(��lem) SQL, SQL Server'�n programsal
--alt yap�s� i�in geli�tirilen, ileri seviye VT geli�tirme
--ve y�netim �zellikleri bulunan bir sorgulama dilidir.

--T-SQL C�mleleri: En �ok kullan�lan T-SQL C�mleleri:
--SELECT INSERT UPDATE DELETE

--Nesne �simleri: Harf ya da _ ile ba�lamal�d�r.
--@ @@ # ## $ ile ba�lamaz.  Bunlar �u ama�la ayr�lm��t�r:
--@   : De�i�ken adlar�
--@@  : Sistem de�i�kenleri
--# ##: Ge�ici nesne belirteci. 

--Tan�mlay�c� isimlerinde T�rk�e harf ve bo�luk
--yer almamal�d�r.

--Tan�mlay�c� isimlendirme Notasyonlar�:
--Camel Notasyonu: ogrenciAdi, ogrenciSoyadi
--Pascal Notasyonu: OgrenciAdi, OgrenciSoyadi       
--Alt �izgi notasyonu: Ogrenci_Adi, Ogrenci_Soyadi
--B�y�k Harf notasyonu: OGRENCI_ADI, OGRENCI_SOYADI  
--Macar Notasyonu: spOGRENCI_EKLE, tbOGRENCI

--NULL Kavram�: Bo�luk ile hi�lik(NULL) ayn� de�ildir.
--Klavyeden bo�luk tu�una bas�larak girilen de�er, 
--(ASCII 32) space anlam�na gelir. NULL ise, hi�bir
--de�er girilmemi�, i�lem yap�lmam�� anlam�na gelir.

select * from tb_ogrenci

--Y���n kavram�, sorgular�n s�rayla i�leme al�nmas�n� 
--ifade eder, arka arkaya komutlar yaz�l�r. Y���nlar,
--parse(ayr��t�r), compile(derle), execute(�al��t�r)
--yap�l�r. 

--GO Komutu: Bir y���n�n sonunu belirtmek i�in kullan�l�r.
--Kullan�m�: 
--Komutlar
--GO

USE DB_TEST
GO
SELECT ad, soyad FROM tb_ogrenci
GO

--USE Komutu: T-SQL kod bloklar�n�n hangi VT i�in 
--�al��t�r�laca��n� belirtir.
--Kullan�m�: USE veritabani_adi

--PRINT(YAZ) Komutu: De�erleri g�sterebilmeye yarar.
--�rnek:
USE DB_TEST
GO
DECLARE @ogrenci NVARCHAR(50)
SET @ogrenci = 'VEL� GEZER'
PRINT @ogrenci
SELECT @ogrenci Ad_Soyad
GO

--Declare=Tan�mla
--SET=Atama yap

--Ba�ka server aras�ndaki ba�lant� ile isimlendirme:
select * FROM [201-16].DB_TEST.dbo.tb_ogrenci
select * from DB_TEST..tb_ogrenci

--CREATE ile Nesne Olu�turma:
--CREATE ile DB'deki nesnelerden biri olu�turulabilir.
--CREATE nesne_tipi nesne_adi
--CREATE ile VT olu�turma:
CREATE DATABASE VT_Test
--VT_Test.mdf
--VT_Test_log.ldf

--IDENTITY: S�tuna otomatik de�er atar, atanan say� 
--seed(ba�lang��) ve increment(art�� miktar�) kadar artar
--ya da azal�r. Seed ve increment i�in varsay�lan de�er
-- 1'dir. De�i�ebilir, �rne�in 1000'den ba�lar, 5'er 5'er
-- art�r�labilir. Identity alanlar say�sal olmak zorundad�r.

--Silinmi� bir identity de�eri tekrar atamak i�in 
--�u kullan�l�r:
--SET IDENTITY_INSERT [dbo].[tablo_adi] ON 
--SET IDENTITY_INSERT [dbo].[tablo_adi] OFF

--Identity ile PRIMARY KEY kavramlar� benzer g�z�kse de
--ayr� kavramlard�r. Primary Key, bir s�tunda bulunan de�erin 
--benzersiz olmas�n� garanti eder ve indexlidir. 
--Identity bir alan ise s�f�rlanarak daha �nce
--art�r�larak sayd�rd���n�z aral�kta yeniden saymaya 
--ba�layabilirsiziniz.

--Milyarlarca y�lda bile tekrarlanmayan bir ID: GUID
SELECT NEWID() AS GUID

--Hesaplanm�� S�tunlar: Anl�k veri g�sterimi i�in 
--asl�nda olmayan bir s�tun olu�turma.
SELECT ad + ' ' + soyad As adSoyad from tb_ogrenci 
SELECT 2023 - dogumYili AS Yas,* from tb_ogrenci 

--DROP(D���rme, silme):
select *
INTO fas
FROM  tb_ogrenci 

--DROP table fas 
--DROP database VT_Test

CREATE database VT_Test

--DROP ba�ar�s�z olursa, DB'de a��lm�� bir ba�lant�
--olmu� olabilir, EXEC sp_who komutu ile bak�labilir. 

--INSERT:
--INSERT INTO tablo_ismi(sutun_ismi1[,sutun_ismi2,...]
--VALUES (deger1[,deger2,deger3,...])

SET IDENTITY_INSERT [dbo].tb_ogrenci ON 
INSERT INTO tb_ogrenci
(ID,ad,soyad,telefon,tc,sinifID,ogretmenID,dogumYili,cinsiyet)
VALUES(101,'Abdullah','G�rsel','12','11',1,1,1989,1)

SET IDENTITY_INSERT [dbo].tb_ogrenci ON 
INSERT INTO tb_ogrenci
VALUES(N'Abdullah',N'G�rsel',N'12',N'11',1,1,1989,1,N'')

select * from tb_ogrenci order by 1 desc

--SELECT:
--SELECT sutun_ismi1[,sutun_ismi2,...]
--FROM tablo_ismi
--WHERE kosul
--ORDER BY sayi/sutun_ismi

--   * : T�m s�tunlar
select * from tb_ogrenci ORDER BY ad 

--UPDATE:
--UPDATE tablo_ismi
--SET alan=deger,...
--WHERE �art_tanimlari

BEGIN TRANSACTION
UPDATE tb_ogrenci SET telefon = '5327747475' WHERE ad='Selim'

select * from tb_ogrenci WHERE ad='Selim'
--ROLLBACK
--COMMIT

select * from tb_ogrenci WHERE ID = 1
BEGIN TRANSACTION
--UPDATE tb_ogrenci SET tc = '33333333333' WHERE ID = 1
COMMIT
BEGIN TRANSACTION
--UPDATE tb_ogrenci SET tc = '55555555555' WHERE ID = 1
ROLLBACK

--DELETE:
--DELETE FROM tablo_ismi
--WHERE �art_tanimlari

BEGIN TRANSACTION
--DELETE FROM tb_ogrenci WHERE ad = '�zge'
ROLLBACK

--DELETE FROM tb_ogrenci WHERE ad Like 'A%'--Ka� kay�t 
--silinece�ini bilmek i�in �ncesinde SELECT 
--�al��t�r�lmal�d�r.
select count(*) FROM tb_ogrenci WHERE ad Like 'A%'

--SELECT:
--Aritmetik Operat�rler: +-*/ %(Mod alma operat�r�).
SELECT dogumYili % 5 FROM tb_ogrenci 

--Atama Operat�r�:
DECLARE @degisken NVARCHAR(50)
SET @degisken = '77'
PRINT @degisken

DECLARE @degisken2 bigint
SET @degisken2 = 77
PRINT @degisken2 * 15

--Metin Birle�tirme(+): Yan yana yap��t�r�r.
SELECT 'Network Akademi' + ' & ' + 'S�n�f 201'

--Distinct ile teke indirgemek: Sadece bir kez getirir.
SELECT dogumYili from tb_ogrenci
SELECT distinct dogumYili from tb_ogrenci

--UNION ve UNION ALL ile sorgu sonu�lar�n� birle�tirme:
SELECT ad FROM tb_ogretmen
UNION ALL
SELECT ad FROM tb_ogrenci
ORDER BY 1

--WHERE ile sorgu sonu�lar�n� filtrelemek:
--��renci tablosundan 5 nolu ��renciyi getirmek, 
--ad�n�n ba� harfi A olanlar� getirmek gibi.
SELECT * from tb_ogrenci WHERE ID = 5
SELECT * from tb_ogrenci WHERE ad LIKE 'Ab%'

--Mant�ksal operat�rler AND: 
SELECT * from tb_ogrenci WHERE ad LIKE '�z%' AND ID=5

--Mant�ksal operat�rler OR: 
SELECT * from tb_ogrenci WHERE ad LIKE 'Ve%' or ad ='�zge'

--Se�me i�leminde or 1=1 eklenerek devre d��� b�rak�lmas�:
SELECT * from tb_ogrenci WHERE ad='' OR 1=1

--Kar��la�t�rma Operat�rleri:
-- < > = <= >= !=(E�it de�il) <>(E�it de�il) LIKE
SELECT * from tb_ogrenci WHERE ID > 5 

--Joker Karakterler:
-- %        Birden fazla harf ya da rakam
-- _        Bir tek harf ya da rakam
-- [AV]     Belirli bir harf ve harfler
-- [^A]     Belirli bir harf de�ilse.
-- [A-Z]    A ile Z aras�ndaki harfleri belirtir.

SELECT * from tb_ogrenci WHERE ad LIKE '[AV]%'
-- A veya V ile ba�layan
SELECT * from tb_ogrenci WHERE ad LIKE '[A-V]%'
-- A V aras�ndaki harfler ile ba�layan
SELECT * from tb_ogrenci WHERE ad like '[AV]%'  --  A veya V ile ba�layan

--BETWEEN...AND..
SELECT * from tb_ogrenci WHERE ad BETWEEN '�zge' AND 'Veysel'
SELECT * from tb_ogrenci WHERE ID BETWEEN 10 AND 20
SELECT * from tb_ogrenci WHERE ID NOT BETWEEN 10 AND 20

IN ve NOT IN :
SELECT * from tb_ogrenci WHERE ID IN (11,12,14,15)
SELECT ad, soyad,telefon from tb_ogrenci WHERE ad IN ('Veysel','�zge')

SPACE Fonksiyonu:
SELECT 'Cihan' + SPACE(3) + '�zhan'
SELECT 'Cihan' + SPACE(10) + '�zhan'

IS NULL Operat�r�:
SELECT * FROM TB_OGRENCi WHERE dogumYili is NULL
SELECT * FROM TB_OGRENCi WHERE dogumYili is NOT NULL

ISNULL Fonksiyonu:
SELECT ad,soyad,dogumYili  FROM TB_OGRENCi  
SELECT ad,soyad,ISNULL(dogumYili,2000)  FROM TB_OGRENCi  

SELECT ad,soyad,AVG(dogumYili) OrtalamaYil  FROM TB_OGRENCi  
SELECT ad,soyad,AVG(ISNULL(dogumYili,2000))  FROM TB_OGRENCi  

ORDER BY:
SELECT * FROM tb_ogrenci ORDER BY ad DESC 

TOP Operat�r�:
SELECT TOP 5 * FROM tb_ogrenci
SELECT TOP 20 PERCENT FROM tb_ogrenci

--Klasik JOIN:
use AdventureWorksLT2012
select * from SalesLT.SalesOrderDetail
select * from SalesLT.Product

select SalesLT.SalesOrderDetail.ProductID, SalesLT.Product.Name
FROM SalesLT.SalesOrderDetail, SalesLT.Product
WHERE SalesLT.SalesOrderDetail.ProductID = SalesLT.Product.ProductID;
--Tablo isimlendirmesi uzun olaca�� i�in, basit bir sorgu bile �ok karma��k
--hal alabilir. Bu nedenle tablolar� takma ad ile isimlendirin. 
select SOD.ProductID, P.Name
FROM SalesLT.SalesOrderDetail SOD, SalesLT.Product P
WHERE SOD.ProductID = P.ProductID;

--SQL Server'da JOIN Mimarisi
USE DB_Test
select *
INTO tb_ogrenci2
FROM  tb_ogrenci 

select *
INTO tb_ogretmen2
FROM  tb_ogretmen 

select *
INTO tb_sinif2
FROM  tb_sinif

--Klasik JOIN:
SELECT o.ad, o.soyad, o.telefon, o.dogumYili, om.ad Ogretmen_Ad,
om.soyad Ogretmen_Soyad 
FROM tb_ogrenci2 o, tb_ogretmen2 om
WHERE o.ogretmenID = om.ID
ORDER BY 1
--Ekin ve Ekrem yok. 

--LEFT JOIN
SELECT o.ad, o.soyad, o.telefon, o.dogumYili, om.ad Ogretmen_Ad,
om.soyad Ogretmen_Soyad 
FROM tb_ogrenci2 o
LEFT JOIN tb_ogretmen2 om
ON o.ogretmenID = om.ID
ORDER BY 1

--INNER JOIN 
SELECT o.ad, o.soyad, o.telefon, o.dogumYili, om.ad Ogretmen_Ad,
om.soyad Ogretmen_Soyad 
FROM tb_ogrenci2 o
INNER JOIN tb_ogretmen2 om
ON o.ogretmenID = om.ID
ORDER BY 1

--RIGHT JOIN
SELECT o.ad, o.soyad, o.telefon, o.dogumYili, om.ad Ogretmen_Ad,
om.soyad Ogretmen_Soyad 
FROM tb_ogrenci2 o
RIGHT JOIN tb_ogretmen2 om
ON o.ogretmenID = om.ID
ORDER BY 5

--FULL OUTER JOIN
SELECT o.ad, o.soyad, o.telefon, o.dogumYili, om.ad Ogretmen_Ad,
om.soyad Ogretmen_Soyad 
FROM tb_ogrenci2 o
FULL OUTER JOIN tb_ogretmen2 om
ON o.ogretmenID = om.ID
ORDER BY 1,5

--Constraint
sp_helpconstraint 'tb_ogrenci'

use db_test
CREATE TABLE Urunler2(
UrunID int,
UrunAd NVARCHAR(200),
UrunFiyat decimal,
CONSTRAINT PKC_UrunID PRIMARY KEY(UrunID)
);

--Mevcut bir tabloda primary key olu�turmak
CREATE TABLE Kullanicilar(
KullaniciID INT NOT NULL,
Ad NVARCHAR(50),
Soyad NVARCHAR(50),
KullaniciAd NVARCHAR(20)
);
--DROP TABLE Kullanicilar

ALTER Table Kullanicilar
ADD Constraint PKC_KullaniciID PRIMARY KEY(KullaniciID);

--Unique Index
use db_test 
CREATE UNIQUE NONCLUSTERED INDEX [NonClusteredIndex-20230214-131853] 
ON [dbo].[tb_alan]
(	[ad] ASC)

ALTER TABLE Kullanicilar
ADD Constraint CHK_SifreUzunluk CHECK(LEN(Sifre) >=5 AND LEN(Sifre) <=15)

sp_helpconstraint 'Kullanicilar'

set IDENTITY_INSERT tb_ogrenci3 ON
INSERT INTO tb_ogrenci3([ad] ,
	[soyad] ,
	[telefon] ,
	[tc] ,
	[sinifID],
	[ogretmenID] ,
	[dogumYili] ,
	[cinsiyet] )
SELECT 
[ad] ,
	[soyad] ,
	[telefon] ,
	[tc] ,
	[sinifID],
	[ogretmenID] ,
	[dogumYili] ,
	[cinsiyet] 
FROM  tb_ogrenci3 


UPDATE tb_ogrenci3 
set ad = (ABS(CHECKSUM(NewId())) % 10000)
where cinsiyet=0


select   * from tb_ogrenci3 where ad='3277'

select   count(*) from tb_ogrenci3

