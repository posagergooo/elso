CREATE DATABASE vasarlas
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci

SELECT tetel.*
FROM tetel
WHERE tetel.termek LIKE "írható DVD" AND tetel.termek LIKE "írható CD"
ORDER BY tetel.bruttoar DESC;

SELECT tetel.termek, tetel.bruttoar/(1+tetel.afa) AS "nettóÁr"
FROM tetel
WHERE tetel.allo = 1;

SELECT tetelo.termek , tetel.datum
FROM tetel
WHERE (tetel.allo and tetel.bruttoar>80000) or (not tetel.allo AND  tetel.bruttoar>30000);

SELECT tetel.datum, tetel.termek, tetel.bruttoar/(1+tetel.afa) as "nettó_darabár"
FROM tetel
WHERE tetel.bruttoar/(1+tetel.afa)>=50000
ORDER BY tetel.datum ASC;

SELECT tetel.termek, tetel.datum, tetel.bruttoar*tetel.mennyiseg AS "összes fizetendő"
FROM tetel
WHERE not tetel.allo and tetel.bruttoar*tetel.mennyiseg<=1000
ORDER BY tetel.datum ASC , tetel.termek ASC;

SELECT tetel.termek
FROM tetel 
WHERE tetel.datum< "2006-01-01";

SELECT tetel.termek as "terméknlv", tetel.datum as "megrendelés", 
tetel.bruttoar as "bruttóÁr", tetel.bruttoar/(tetel.afa+1) as "nettóÁr"
FROM tetel
WHERE tetel.termek LIKE "% tintapatron cián"
ORDER BY tetel.datum ASC;
