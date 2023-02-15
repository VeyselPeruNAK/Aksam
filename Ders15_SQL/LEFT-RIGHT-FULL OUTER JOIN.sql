--***** M�LAKATTA �IKAB�L�R ******
--***** �� HAYATINDA KES�N �IKAR ******

SELECT * FROM tb_Alan;
SELECT * FROM tb_Sinif;
SELECT * FROM tb_Ogrenci;
SELECT * FROM tb_Ogretmen;

--INSERT INTO tb_Ogrenci (ad,soyad,dogumYili,sinifID) 
--VALUES ('Seyhan','KARACA',1995,2);

INSERT INTO tb_Ogretmen (ad,soyad,telefon,alanID) VALUES('Veysel','Ero�lugil','03463211232',3);

-- INNER JOIN/JOIN iki tabloda ON ile belirtilen kolonlar dolu ise 
-- listeler.
-- ��retmeni olan t�m ��rencileri listele (��retmeni olmazsa listelemez veya ��retmenin ��rencisi yoksa listelemez). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci INNER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;

SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- LEFT JOIN (FROM'dan sonra ve ON'dan sonra yazd���m�z tablo ad� SOLDAK�'dir.)
-- T�m ��rencileri listele (��retmeni olmasa da ��rencilerin tamam�n�,��retmenlerin sadece ��rencisi olanlar�
-- listeler). 
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci LEFT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- RIGHT JOIN: soldaki:��renci tablosundan ��retmeni olanlar� al�rken 
-- sa�daki tablo:��retmenlerin tamam�n� listeler.
SELECT tb_Ogrenci.ad,tb_Ogrenci.soyad,CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci RIGHT JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- FULL OUTER JOIN: her iki tablodada kar��l���nda veri olmas�na bakmaks�z�n
-- t�m sat�rlar� getirir.sa�da ve solda NULL kolonlar olabilir.

SELECT 
CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as ��renci,
CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
FROM tb_Ogrenci
FULL OUTER JOIN tb_Ogretmen
ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;
