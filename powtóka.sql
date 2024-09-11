1
SELECT * FROM futrzaki;
2
SELECT * FROM futrzaki WHERE DATE(data_urodzenia) > '2015-08-07';
3
SELECT gatunek_futrzaka, cena_wykupu FROM futrzaki WHERE cena_wykupu > 600 ORDER BY cena_wykupu ASC;
4
SELECT imie, nazwisko FROM pracownicy WHERE LENGTH(imie) > LENGTH(nazwisko);
5
SELECT nazwisko FROM opiekunowie WHERE imie IN('Arnold','Yuri','Neo');
6
SELECT DISTINCT id_futrzaka FROM egzemplarze WHERE czy_jest = 'T' ORDER BY id_futrzaka DESC;
7
SELECT DISTINCT id_opiekuna FROM opieka_czasowa WHERE DATE(data_odbioru) BETWEEN '2000-01-01' AND '2009-01-01' ORDER BY id_opiekuna DESC;
8
SELECT id_opiekuna 'Id opiekuna', DATEDIFF(data_zwrotu, data_odbioru) 'Ilosc dni' FROM opieka_czasowa ORDER BY DATEDIFF(data_zwrotu, data_odbioru) DESC;
9
SELECT CONCAT(imie, ' ' , nazwisko) "imię i nazwisko"
FROM pracownicy
10
SELECT CONCAT(LEFT(imie,1), '.', nazwisko) "mr name"
FROM pracownicy   
11
SELECT gatunek_futrzaka FROM futrzaki 
ORDER BY LENGTH(gatunek_futrzaka) DESC
LIMIT 3
12
SELECT LEFT(imie,1) "pierwsza imienia", RIGHT(nazwisko,1) "ostatnia nazwiska"
FROM pracownicy 
13
SELECT imie FROM pracownicy
WHERE LEFT(imie,1) = RIGHT(nazwisko,1)
14
SELECT nazwisko FROM pracownicy WHERE nazwisko LIKE"%g%"
15
SELECT nazwisko FROM pracownicy WHERE nazwisko LIKE "_c%" OR nazwisko LIKE "__c%" OR nazwisko LIKE "_r%" OR nazwisko LIKE "__r%"
16
SELECT CONCAT(LOWER(imie), '.', LOWER(nazwisko), '@gmail.com') FROM opiekunowie
17
SELECT * FROM futrzaki f
JOIN egzemplarze e ON f.id_futrzaka = e.id_futrzaka
WHERE 












