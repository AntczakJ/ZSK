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
SELECT * FROM futrzaki ORDER BY data_urodzenia ASC LIMIT 3;
18
SELECT e.id_egzemplarza , f.gatunek_futrzaka from egzemplarze e
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
19
SELECT f.gatunek_futrzaka FROM futrzaki f
JOIN egzemplarze e ON f.id_futrzaka = e.id_futrzaka
WHERE e.czy_jest = 'T';
20
SELECT f.gatunek_futrzaka , e.data_urodzenia FROM futrzaki f
JOIN egzemplarze e ON f.id_futrzaka = e.id_futrzaka
WHERE LEFT(e.data_urodzenia,2) = "19";
21
SELECT op.nazwisko, f.gatunek_futrzaka FROM opieka_czasowa o
JOIN opiekunowie op ON o.id_opiekuna = op.id_opiekuna
JOIN egzemplarze e ON e.id_egzemplarza = o.id_egzemplarza
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
22
SELECT f.gatunek_futrzaka, e.data_urodzenia FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
JOIN opieka_czasowa o ON e.id_egzemplarza = o.id_egzemplarza
JOIN opiekunowie op ON o.id_opiekuna = op.id_opiekuna
WHERE op.nazwisko = "Lee";
23
SELECT o.nazwisko FROM opieka_czasowa op
JOIN opiekunowie o ON o.id_opiekuna = op.id_opiekuna
ORDER BY op.data_odbioru ASC
LIMIT 1;
24
SELECT op.nazwisko, f.gatunek_futrzaka FROM opieka_czasowa o
JOIN opiekunowie op ON o.id_opiekuna = op.id_opiekuna
JOIN egzemplarze e ON e.id_egzemplarza = o.id_egzemplarza
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
WHERE f.gatunek_futrzaka = "Koala"
25
SELECT f.gatunek_futrzaka FROM futrzaki f
JOIN egzemplarze e ON f.id_futrzaka = e.id_futrzaka
WHERE e.czy_jest = 'N';
26
SELECT distinct o.nazwisko FROM opieka_czasowa op
JOIN opiekunowie o ON o.id_opiekuna = op.id_opiekuna
WHERE op.data_odbioru > '1998-07-01' AND op.data_odbioru < '2007-06-04'
27
SELECT op.nazwisko, op.imie FROM opieka_czasowa o
JOIN opiekunowie op ON o.id_opiekuna = op.id_opiekuna
JOIN egzemplarze e ON e.id_egzemplarza = o.id_egzemplarza
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
WHERE left(f.gatunek_futrzaka,1) = LEFT(op.imie,1)
28
SELECT AVG(cena_wykupu) FROM futrzaki
GROUP BY LEFT(gatunek_futrzaka,1)
29
SELECT AVG(cena_wykupu) FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
WHERE LEFT(e.data_urodzenia,4) % 2 = 0
30
SELECT round(AVG(cena_wykupu),2) FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
WHERE LEFT(e.data_urodzenia,4) % 2 = 1
31
SELECT DISTINCT COUNT(f.gatunek_futrzaka) from futrzaki f
32
SELECT f.gatunek_futrzaka AS nazwa_gatunku, COUNT(e.id_egzemplarza) AS ilosc
FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
GROUP BY f.gatunek_futrzaka
ORDER BY ilosc DESC;
33
SELECT cena_wykupu FROM futrzaki 
ORDER BY 1 ASC
LIMIT 1
34
SELECT LEFT(e.data_urodzenia,4) rok, COUNT(e.id_futrzaka) ilość FROM egzemplarze e
GROUP BY e.id_futrzaka
HAVING COUNT(e.id_futrzaka) > 1
35
SELECT f.gatunek_futrzaka nazwa, SUM(f.cena_wykupu) cena FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
WHERE e.czy_jest = 'N'
GROUP BY f.gatunek_futrzaka
36
SELECT LEFT(p.nazwisko,1) litera, COUNT(LEFT(p.nazwisko,1)) FROM pracownicy p
GROUP BY LEFT(p.nazwisko,1)

















