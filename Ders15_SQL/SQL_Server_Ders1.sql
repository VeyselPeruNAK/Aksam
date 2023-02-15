--RDBMS (Relational Database Management Systems)
--Ýliþkisel Veritabaný Yönetim Sistemleri
--SQL Server: Dünya'da bireysel ve kurumsal en çok tercih
--edilen, düþük maliyetli, yüksek performanslý, Windows
--iþletim sistemi üzerinde çalýþan, SQL standardýný
--destekleyen, kendine özgü T-SQL sorgu diline sahip,
--geliþmiþ bir Ýliþkisel Veritabaný Yönetim Sistemidir.
 
--Baþka örnek RDBMS: Oracle, DB2, MySql, PostgreSQL

--Transact-SQL = T-SQL

--VERÝTABANI NESNELERÝ:
--Database Table Index Diagram View User Stored Procedure
--Function Trigger vb.

--Database nesnesi: Diðer nesnelerin bir çoðu DB nesnesinin
--elemanlarýdýr. DB'ler table index diagram view User 
--Stored Procedure gibi bir çok nesneyi içinde barýndýrýr.

--Master Veritabaný: Sistemin bütününü izlemeye yarar, 
--sistem tablolarý kümesini içine alýr.
SELECT * from SYS.databases 
EXEC sp_who

--Diagramlar: Tablolarýn iliþkilendirilmelerini gösteren
--ve yönetebileceðimiz bir VT görselleþtirme aracýdýr.

--Þemalar: DB içindeki nesnelerin mantýksal isimlendirmesini
--yapar. 
--dbo þemasý: Database Owner(VT sahibi) demektir, varsayýlan
--þemadýr.
SELECT * from tb_ogrenci

--Tablolar: DB'nin en temel yapýsýdýr. Satýr ve sütunlardan 
--oluþur. Alan veri(sütunlar), alan oluþturmak ve bu 
--alanlara yazýlacak verinin tipini belirtmeye yarar.
--Kayýt veri(satýrlar), alanlara veri girilmesiyle oluþur.

--Index'ler: Tablo ve viewlar için bulunan bir nesnedir.
--Index, sýralama iþlemini daha disiplinli yaparak 
--performans artýrmayý ve hýzlý sorgu sonucu döndürmeyi
--amaçlar. 

--Constraint(Kýsýtlamalar): Tablolar içinde veri 
--bütünlüðünü saðlamayý amaçlar.

--View'lar(Görünüm): View bir ya da birden fazla tablonun
--sanal görüntüsüdür. Kullaným nedenleri:Güvenlik, 
--performans ve kullaným kolaylýðýdýr. 

--Stored Procedures(Saklý Yordamlar): Stored Procedures
--diðer adýyla sproc'lar SQL Server programlama(T-SQL)
--alt yapýsýnýn en önemli ve çok kullanýlan 
--özelliklerinden birisidir. Sproc'lar VT'de yapýlacak
--iþlemlerin bir program düzeninde gerçekleþmesini 
--saðlayan T-SQL programcýklarýdýr. Deðiþkenler, 
--girdi-çýktý parametreleri, klasik SQL sorgularý 
--gibi birçok özelliði kullanýr. Güvenlik, performans ve
--hýzlý iþlem gerçekleþtirebilme gibi bir çok faydaya
--sahiptir. Ýç içe de kullanýlabilir.

--Triggers(Tetikleyiciler): Tablolar üzerinde ekleme,
--güncelleme, silme ve kopyalama gibi iþlemlerin 
--gerçekleþmeden önce veya sonra yapýlmasý gereken
--iþlemlerin otomatik olarak gerçekleþmesini saðlayan
--T-SQL programcýklarýdýr. 

--T-SQL Transact(Ýþlem) SQL, SQL Server'ýn programsal
--alt yapýsý için geliþtirilen, ileri seviye VT geliþtirme
--ve yönetim özellikleri bulunan bir sorgulama dilidir.

--T-SQL Cümleleri: En çok kullanýlan T-SQL Cümleleri:
--SELECT INSERT UPDATE DELETE

--Nesne Ýsimleri: Harf ya da _ ile baþlamalýdýr.
--@ @@ # ## $ ile baþlamaz.  Bunlar þu amaçla ayrýlmýþtýr:
--@   : Deðiþken adlarý
--@@  : Sistem deðiþkenleri
--# ##: Geçici nesne belirteci. 

--Tanýmlayýcý isimlerinde Türkçe harf ve boþluk
--yer almamalýdýr.

--Tanýmlayýcý isimlendirme Notasyonlarý:
--Camel Notasyonu: ogrenciAdi, ogrenciSoyadi
--Pascal Notasyonu: OgrenciAdi, OgrenciSoyadi       
--Alt çizgi notasyonu: Ogrenci_Adi, Ogrenci_Soyadi
--Büyük Harf notasyonu: OGRENCI_ADI, OGRENCI_SOYADI  
--Macar Notasyonu: spOGRENCI_EKLE, tbOGRENCI

--NULL Kavramý: Boþluk ile hiçlik(NULL) ayný deðildir.
--Klavyeden boþluk tuþuna basýlarak girilen deðer, 
--(ASCII 32) space anlamýna gelir. NULL ise, hiçbir
--deðer girilmemiþ, iþlem yapýlmamýþ anlamýna gelir.

select * from tb_ogrenci

--Yýðýn kavramý, sorgularýn sýrayla iþleme alýnmasýný 
--ifade eder, arka arkaya komutlar yazýlýr. Yýðýnlar,
--parse(ayrýþtýr), compile(derle), execute(çalýþtýr)
--yapýlýr. 

--GO Komutu: Bir yýðýnýn sonunu belirtmek için kullanýlýr.
--Kullanýmý: 
--Komutlar
--GO

USE DB_TEST
GO
SELECT ad, soyad FROM tb_ogrenci
GO

--USE Komutu: T-SQL kod bloklarýnýn hangi VT için 
--çalýþtýrýlacaðýný belirtir.
--Kullanýmý: USE veritabani_adi

--PRINT(YAZ) Komutu: Deðerleri gösterebilmeye yarar.
--Örnek:
USE DB_TEST
GO
DECLARE @ogrenci NVARCHAR(50)
SET @ogrenci = 'VELÝ GEZER'
PRINT @ogrenci
SELECT @ogrenci Ad_Soyad
GO

--Declare=Tanýmla
--SET=Atama yap

--Baþka server arasýndaki baðlantý ile isimlendirme:
select * FROM [201-16].DB_TEST.dbo.tb_ogrenci
select * from DB_TEST..tb_ogrenci

--CREATE ile Nesne Oluþturma:
--CREATE ile DB'deki nesnelerden biri oluþturulabilir.
--CREATE nesne_tipi nesne_adi
--CREATE ile VT oluþturma:
CREATE DATABASE VT_Test
--VT_Test.mdf
--VT_Test_log.ldf

--IDENTITY: Sütuna otomatik deðer atar, atanan sayý 
--seed(baþlangýç) ve increment(artýþ miktarý) kadar artar
--ya da azalýr. Seed ve increment için varsayýlan deðer
-- 1'dir. Deðiþebilir, örneðin 1000'den baþlar, 5'er 5'er
-- artýrýlabilir. Identity alanlar sayýsal olmak zorundadýr.

--Silinmiþ bir identity deðeri tekrar atamak için 
--þu kullanýlýr:
--SET IDENTITY_INSERT [dbo].[tablo_adi] ON 
--SET IDENTITY_INSERT [dbo].[tablo_adi] OFF

--Identity ile PRIMARY KEY kavramlarý benzer gözükse de
--ayrý kavramlardýr. Primary Key, bir sütunda bulunan deðerin 
--benzersiz olmasýný garanti eder ve indexlidir. 
--Identity bir alan ise sýfýrlanarak daha önce
--artýrýlarak saydýrdýðýnýz aralýkta yeniden saymaya 
--baþlayabilirsiziniz.

--Milyarlarca yýlda bile tekrarlanmayan bir ID: GUID
SELECT NEWID() AS GUID

--Hesaplanmýþ Sütunlar: Anlýk veri gösterimi için 
--aslýnda olmayan bir sütun oluþturma.
SELECT ad + ' ' + soyad As adSoyad from tb_ogrenci 
SELECT 2023 - dogumYili AS Yas,* from tb_ogrenci 

--DROP(Düþürme, silme):
select *
INTO fas
FROM  tb_ogrenci 

--DROP table fas 
--DROP database VT_Test

CREATE database VT_Test

--DROP baþarýsýz olursa, DB'de açýlmýþ bir baðlantý
--olmuþ olabilir, EXEC sp_who komutu ile bakýlabilir. 

--INSERT:
--INSERT INTO tablo_ismi(sutun_ismi1[,sutun_ismi2,...]
--VALUES (deger1[,deger2,deger3,...])

SET IDENTITY_INSERT [dbo].tb_ogrenci ON 
INSERT INTO tb_ogrenci
(ID,ad,soyad,telefon,tc,sinifID,ogretmenID,dogumYili,cinsiyet)
VALUES(101,'Abdullah','Gürsel','12','11',1,1,1989,1)

SET IDENTITY_INSERT [dbo].tb_ogrenci ON 
INSERT INTO tb_ogrenci
VALUES(N'Abdullah',N'Gürsel',N'12',N'11',1,1,1989,1,N'')

select * from tb_ogrenci order by 1 desc

--SELECT:
--SELECT sutun_ismi1[,sutun_ismi2,...]
--FROM tablo_ismi
--WHERE kosul
--ORDER BY sayi/sutun_ismi

--   * : Tüm sütunlar
select * from tb_ogrenci ORDER BY ad 

--UPDATE:
--UPDATE tablo_ismi
--SET alan=deger,...
--WHERE þart_tanimlari

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
--WHERE þart_tanimlari

BEGIN TRANSACTION
--DELETE FROM tb_ogrenci WHERE ad = 'Özge'
ROLLBACK

--DELETE FROM tb_ogrenci WHERE ad Like 'A%'--Kaç kayýt 
--silineceðini bilmek için öncesinde SELECT 
--çalýþtýrýlmalýdýr.
select count(*) FROM tb_ogrenci WHERE ad Like 'A%'

--SELECT:
--Aritmetik Operatörler: +-*/ %(Mod alma operatörü).
SELECT dogumYili % 5 FROM tb_ogrenci 

--Atama Operatörü:
DECLARE @degisken NVARCHAR(50)
SET @degisken = '77'
PRINT @degisken

DECLARE @degisken2 bigint
SET @degisken2 = 77
PRINT @degisken2 * 15

--Metin Birleþtirme(+): Yan yana yapýþtýrýr.
SELECT 'Network Akademi' + ' & ' + 'Sýnýf 201'

--Distinct ile teke indirgemek: Sadece bir kez getirir.
SELECT dogumYili from tb_ogrenci
SELECT distinct dogumYili from tb_ogrenci

--UNION ve UNION ALL ile sorgu sonuçlarýný birleþtirme:
SELECT ad FROM tb_ogretmen
UNION ALL
SELECT ad FROM tb_ogrenci
ORDER BY 1

--WHERE ile sorgu sonuçlarýný filtrelemek:
--Öðrenci tablosundan 5 nolu öðrenciyi getirmek, 
--adýnýn baþ harfi A olanlarý getirmek gibi.
SELECT * from tb_ogrenci WHERE ID = 5
SELECT * from tb_ogrenci WHERE ad LIKE 'Ab%'

--Mantýksal operatörler AND: 
SELECT * from tb_ogrenci WHERE ad LIKE 'Öz%' AND ID=5

--Mantýksal operatörler OR: 
SELECT * from tb_ogrenci WHERE ad LIKE 'Ve%' or ad ='Özge'

--Seçme iþleminde or 1=1 eklenerek devre dýþý býrakýlmasý:
SELECT * from tb_ogrenci WHERE ad='' OR 1=1

--Karþýlaþtýrma Operatörleri:
-- < > = <= >= !=(Eþit deðil) <>(Eþit deðil) LIKE
SELECT * from tb_ogrenci WHERE ID > 5 

--Joker Karakterler:
-- %        Birden fazla harf ya da rakam
-- _        Bir tek harf ya da rakam
-- [AV]     Belirli bir harf ve harfler
-- [^A]     Belirli bir harf deðilse.
-- [A-Z]    A ile Z arasýndaki harfleri belirtir.

SELECT * from tb_ogrenci WHERE ad LIKE '[AV]%'
-- A veya V ile baþlayan
SELECT * from tb_ogrenci WHERE ad LIKE '[A-V]%'
-- A V arasýndaki harfler ile baþlayan
SELECT * from tb_ogrenci WHERE ad like '[AV]%'  --  A veya V ile baþlayan

--BETWEEN...AND..
SELECT * from tb_ogrenci WHERE ad BETWEEN 'Özge' AND 'Veysel'
SELECT * from tb_ogrenci WHERE ID BETWEEN 10 AND 20
SELECT * from tb_ogrenci WHERE ID NOT BETWEEN 10 AND 20

IN ve NOT IN :
SELECT * from tb_ogrenci WHERE ID IN (11,12,14,15)
SELECT ad, soyad,telefon from tb_ogrenci WHERE ad IN ('Veysel','Özge')

SPACE Fonksiyonu:
SELECT 'Cihan' + SPACE(3) + 'Özhan'
SELECT 'Cihan' + SPACE(10) + 'Özhan'

IS NULL Operatörü:
SELECT * FROM TB_OGRENCi WHERE dogumYili is NULL
SELECT * FROM TB_OGRENCi WHERE dogumYili is NOT NULL

ISNULL Fonksiyonu:
SELECT ad,soyad,dogumYili  FROM TB_OGRENCi  
SELECT ad,soyad,ISNULL(dogumYili,2000)  FROM TB_OGRENCi  

SELECT ad,soyad,AVG(dogumYili) OrtalamaYil  FROM TB_OGRENCi  
SELECT ad,soyad,AVG(ISNULL(dogumYili,2000))  FROM TB_OGRENCi  

ORDER BY:
SELECT * FROM tb_ogrenci ORDER BY ad DESC 

TOP Operatörü:
SELECT TOP 5 * FROM tb_ogrenci
SELECT TOP 20 PERCENT FROM tb_ogrenci

--Klasik JOIN:
use AdventureWorksLT2012
select * from SalesLT.SalesOrderDetail
select * from SalesLT.Product

select SalesLT.SalesOrderDetail.ProductID, SalesLT.Product.Name
FROM SalesLT.SalesOrderDetail, SalesLT.Product
WHERE SalesLT.SalesOrderDetail.ProductID = SalesLT.Product.ProductID;
--Tablo isimlendirmesi uzun olacaðý için, basit bir sorgu bile çok karmaþýk
--hal alabilir. Bu nedenle tablolarý takma ad ile isimlendirin. 
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

--Mevcut bir tabloda primary key oluþturmak
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

