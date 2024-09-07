 SELECT * FROM futrzaki;

SELECT * FROM futrzaki WHERE DATE(data_urodzenia) > '2015-08-07';

SELECT gatunek_futrzaka, cena_wykupu FROM futrzaki WHERE cena_wykupu > 600 ORDER BY cena_wykupu ASC;

SELECT imie, nazwisko FROM pracownicy WHERE LENGTH(imie) > LENGTH(nazwisko);

SELECT nazwisko FROM opiekunowie WHERE imie IN('Arnold','Yuri','Neo');

SELECT DISTINCT id_futrzaka FROM egzemplarze WHERE czy_jest = 'T' ORDER BY id_futrzaka DESC;

SELECT DISTINCT id_opiekuna FROM opieka_czasowa WHERE DATE(data_odbioru) BETWEEN '2000-01-01' AND '2009-01-01' ORDER BY id_opiekuna DESC;

SELECT id_opiekuna 'Id opiekuna', DATEDIFF(data_zwrotu, data_odbioru) 'Ilosc dni' FROM opieka_czasowa ORDER BY id_opiekuna DESC;
