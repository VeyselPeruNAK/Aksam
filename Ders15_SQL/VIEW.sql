-- VIEW: Sanal tablo olu�turmam�z� sa�lar. A�a��daki gibi karma��k ve uzun sorgular� 
-- view olarak tan�mlad���m�zda sanki o detayl� sorgunun sonucu bir tabloymu��as�na 
-- tablodan veri �ekebiliriz.

---- VIEW TANIMLAMA
--CREATE VIEW OgrenciOgretmen AS
--	SELECT 
--	CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as ��renci,
--	CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
--	FROM tb_Ogrenci INNER JOIN tb_Ogretmen
--	ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;



---- VIEW D�ZENLEME
--ALTER VIEW OgrenciOgretmen AS
--	SELECT 
--	CONCAT(tb_Ogrenci.ad,' ',tb_Ogrenci.soyad) as ��renci,
--	CONCAT(tb_Ogretmen.ad,' ',tb_Ogretmen.soyad) as ��retmen
--	FROM tb_Ogrenci INNER JOIN tb_Ogretmen
--	ON tb_Ogrenci.ogretmenID=tb_Ogretmen.ID;


-- VIEW SORGULAMA
-- T�m kolonlar� getir.
--SELECT * FROM OgrenciOgretmen;

---- Belirli kolonlar� getir.
--SELECT ��renci FROM OgrenciOgretmen;
--SELECT ��retmen FROM OgrenciOgretmen;