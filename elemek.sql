CREATE DATABASE elemek
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci

CREATE TABLE felfedez(
rendszam INT PRIMARY KEY NOT NULL,
vegyjel VARCHAR(50), 
elemneve VARCHAR(50),
felfedeve INT,
felfedezo VARCHAR(50),
gaz BOOLEAN);

UPDATE felfedez SET felfedez.felfedeve= NULL
WHERE felfedez.felfedezve=0;

UPDATE felfedez SET felfedez.felfedezo= NULL
WHERE felfedez.felfedezo LIKE "";

SELECT felfedez.elemneve
FROM felfedez
WHERE felfedez.gaz=1 
ORDER BY felfedez.elemneve ASC;

SELECT felfedez.elemneve
FROM felfedez
WHERE felfedez.felfedeve IS null;

SELECT felfedez.elemneve, felfedez.felfedeve, felfedez.felfedezo
FROM felfedez
WHERE felfedez.felfedezo is not null
ORDER BY felfedez.felfedezo ASC,felfedez.felfedeve ASC;

SELECT felfedez.elemneve, felfedez.felfedeve, felfedez.felfedezo
FROM felfedez
WHERE felfedez.felfedezo IN ("Hevesy Görgy","Müller Ferenc");

SELECT felfedez.*
FROM felfedez
WHERE felfedez.felfedeve BETWEEN 1800 and 1850;

SELECT DISTINCT felfedez.felfedezo
FROM felfedez
WHERE felfedez.felfedezo IS NOT NULL
ORDER BY felfedez.felfedezo ASC;

SELECT felfedez.elemneve, felfedez.felfedeve
FROM felfedez
WHERE felfedez.gaz
ORDER BY felfedez.felfedeve ASC
LIMIT 1;

SELECT felfedez.*
FROM felfedez
WHERE felfedez.vegyjel LIKE "_";

SELECT felfedez.*
FROM felfedez
WHERE felfedez.gaz AND felfedez.vegyjel LIKE "__%";

SELECT felfedez.elemneve 
FROM felfedez
WHERE felfedez.felfedezo LIKE "%Scheele%";

SELECT felfedez.elemneve 
FROM felfedez
WHERE felfedez.felfedezo LIKE "%Scheele%"
ORDER BY felfedez.felfedeve DESC
LIMIT 1;

SELECT felfedez.elemneve 
FROM felfedez
WHERE felfedez.felfedezo LIKE "%Scheele%" and felfedez.gaz;

SELECT felfedez.elemneve 
FROM felfedez
WHERE felfedez.felfedezo LIKE "%Scheele%" and not felfedez.gaz;
ORDER BY felfedez.felfedeve
LIMIT 1;
