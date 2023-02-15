 CREATE DATABASE OKUL_VT; -- OKUL_VT isminde bir veritaban� olu�turduk.
USE OKUL_VT
-- DROP DATABASE OKUL_VT; -- OKUL_VT veritaban�n� siler.

USE OKUL_VT; -- OKUL_VT veritaban�n� kullan.

-- Tablo olu�turuyoruz.
--DROP Table tb_Ogrenci ;
SELECT * from tb_Ogrenci
CREATE TABLE tb_Ogrenci 
(
	numara int,
	ad nvarchar(50),
	soyad nvarchar(50),
	dogumYili smallint,
	sinif varchar(5)
);

-- Tabloyu d�zenliyoruz.

ALTER TABLE tb_Ogrenci ALTER COLUMN numara INT NOT NULL;
ALTER TABLE tb_Ogrenci ALTER COLUMN ad nvarchar(60) NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN soyad nvarchar(60) NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN dogumYili smallint NOT NULL;
ALTER TABLE tb_Ogrenci  ALTER COLUMN sinif varchar(5) NOT NULL;

-- nuamra y� primary key yapt�k.
ALTER TABLE [dbo].[tb_Ogrenci] ADD  CONSTRAINT [PK_tb_Ogrenci] PRIMARY KEY CLUSTERED (	[numara] ASC)

ALTER TABLE tb_Ogrenci DROP CONSTRAINT  PK_tb_Ogrenci;
ALTER TABLE tb_Ogrenci DROP column numara;
ALTER TABLE tb_Ogrenci ADD numara int NOT NULL IDENTITY(1,1) PRIMARY KEY;