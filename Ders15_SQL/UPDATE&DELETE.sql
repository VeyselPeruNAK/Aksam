USE DB_Test 
--SELECT * FROM tb_Alan;

UPDATE tb_Alan SET ad='Elektrik & Elektronik' WHERE ID=5;

SELECT * FROM tb_Ogretmen;

UPDATE tb_Ogretmen SET telefon='05462223344', alan=5 WHERE ID=4;
SELECT * FROM tb_Alan;
DELETE FROM tb_Alan WHERE ID=4;

SELECT * FROM tb_Ogretmen;