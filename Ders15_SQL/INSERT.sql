USE [DB_Test]
GO

INSERT INTO [dbo].[tb_Ogrenci]
           ([ad]
           ,[soyad]
           ,[dogumYili]
           ,[sinifId]
           ,[ogretmenID],
		   telefon,
		   tc)
     VALUES
           ('Kemal',
           'Çelik',
            1980,
           1,
           1,
		   5325556565,
		   55555666667)
--GO

--DELETE FROM tb_Ogrenci;
SELECT * FROM tb_Ogrenci;

INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID,telefon,tc) VALUES('Selim','GÜR',1990,1,1,5332223343,56565656567); 
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('Hercai','KILIÇ',1980,1,2,5354445454,33333444445); 
INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID,ogretmenID) VALUES('Mürsel','TORBA',1997,2,3,5365456677,23232323232); 


SELECT * FROM tb_Ogretmen;
SELECT * FROM tb_Ogrenci;




--USE [OKUL_VT]
--GO
INSERT INTO [dbo].[tb_Ogretmen]
           ([ad]
           ,[soyad]
           ,[telefon]
           ,[alan])
     VALUES
           ('Serra',
		   'KARACA',
           '02161231223',
           1)
--GO

INSERT INTO tb_Ogretmen (ad,soyad,telefon,alan) VALUES ('Süreyya','KAÇAR','05673452321',1);
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alan) VALUES ('Necla','KESER','05673451222',2);
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alan) VALUES ('Süha','GEZER','05673452321',3);
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alan) VALUES ('Mümtaz','RÜZGAR','05673452121',6);
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alan) VALUES ('Meliha','DELÝCE','05673452121',6);
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alan) VALUES ('Dursun','SADIK','05673452121',3);
INSERT INTO tb_Ogretmen (ad,soyad,telefon,alan) VALUES ('Mehmet','GÜRSES','05673452121',2);

SELECT * FROM tb_Ogretmen;


--USE OKUL_VT;
--INSERT INTO tb_Alan (ad) VALUES('Bilgisayar');
--INSERT INTO tb_Alan (ad) VALUES('Kimya');
--INSERT INTO tb_Alan (ad) VALUES('Biyoloji');
--INSERT INTO tb_Alan (ad) VALUES('Fizik');
--INSERT INTO tb_Alan (ad) VALUES('Elektronik');
--INSERT INTO tb_Alan (ad) VALUES('Metalurji');
--INSERT INTO tb_Alan (ad) VALUES('Raylý Sistemler Mühendisliði');

SELECT * FROM tb_Alan;




SELECT * FROM tb_Ogrenci;
SELECT * FROM tb_Ogretmen;
SELECT * FROM tb_Sinif;
SELECT * FROM tb_Alan;


INSERT INTO tb_Sinif (ad,kat) VALUES('d203',2);
INSERT INTO tb_Sinif (ad,kat) VALUES('d201',2);
INSERT INTO tb_Sinif (ad,kat) VALUES('d103',1);
INSERT INTO tb_Sinif (ad,kat) VALUES('d101',1);





