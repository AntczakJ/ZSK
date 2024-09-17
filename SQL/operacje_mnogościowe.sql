1
(SELECT p.nazwisko FROM pracownicy p)
UNION all
(SELECT o.nazwisko FROM opiekunowie o)
ORDER BY 1 ASC;
2
(SELECT f.gatunek_futrzaka, f.id_futrzaka FROM futrzaki f
JOIN karmienie k ON k.id_futrzaka = f.id_futrzaka
JOIN pracownicy p ON p.id_pracownika = k.id_pracownika
WHERE p.nazwisko = "Boczek")
intersect 
(SELECT f.gatunek_futrzaka, f.id_futrzaka FROM futrzaki f
JOIN karmienie k ON k.id_futrzaka = f.id_futrzaka
JOIN pracownicy p ON p.id_pracownika = k.id_pracownika
WHERE p.nazwisko = "Pazura");
3
(SELECT f.gatunek_futrzaka, f.id_futrzaka FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
JOIN opieka_czasowa op ON e.id_egzemplarza = op.id_egzemplarza
JOIN opiekunowie o ON o.id_opiekuna = op.id_opiekuna
WHERE o.nazwisko = "Stallone")
intersect
(SELECT f.gatunek_futrzaka, f.id_futrzaka FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
JOIN opieka_czasowa op ON e.id_egzemplarza = op.id_egzemplarza
JOIN opiekunowie o ON o.id_opiekuna = op.id_opiekuna
WHERE o.nazwisko = "Andersson");
4
(SELECT f.gatunek_futrzaka, f.id_futrzaka FROM futrzaki f
JOIN karmienie k ON k.id_futrzaka = f.id_futrzaka
JOIN pracownicy p ON p.id_pracownika = k.id_pracownika
WHERE p.nazwisko IN ('Geller','Pazura'))
EXCEPT
(SELECT f.gatunek_futrzaka, f.id_futrzaka FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
JOIN opieka_czasowa op ON e.id_egzemplarza = op.id_egzemplarza
JOIN opiekunowie o ON o.id_opiekuna = op.id_opiekuna
WHERE o.nazwisko IN ('Stallone','Lee'));
5
(SELECT f.gatunek_futrzaka FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
WHERE e.czy_jest = 'T')
EXCEPT
(SELECT f.gatunek_futrzaka FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
JOIN opieka_czasowa op ON e.id_egzemplarza = op.id_egzemplarza);
6
(SELECT f.gatunek_futrzaka FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
WHERE e.czy_jest = 'T')
EXCEPT
(SELECT f.gatunek_futrzaka FROM futrzaki f
JOIN egzemplarze e ON e.id_futrzaka = f.id_futrzaka
JOIN opieka_czasowa op ON e.id_egzemplarza = op.id_egzemplarza
WHERE DATEDIFF(op.data_zwrotu,op.data_odbioru) >= 471
ORDER BY 1 ASC);
7
(SELECT e.id_egzemplarza, f.gatunek_futrzaka FROM egzemplarze e
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
JOIN opieka_czasowa op ON e.id_egzemplarza = op.id_egzemplarza
JOIN opiekunowie o ON op.id_opiekuna = o.id_opiekuna
WHERE o.nazwisko REGEXP '^[A-J]')
intersect
(SELECT e.id_egzemplarza, f.gatunek_futrzaka FROM egzemplarze e
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
JOIN karmienie k ON k.id_futrzaka = f.id_futrzaka
JOIN pracownicy p ON p.id_pracownika = k.id_pracownika
WHERE p.nazwisko REGEXP '^[A-J]');
8
SELECT LEFT(f.gatunek_futrzaka,1), AVG(f.cena_wykupu) FROM egzemplarze e
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
GROUP BY LEFT(f.gatunek_futrzaka, 1)
ORDER BY 1 DESC;
9
SELECT AVG(f.cena_wykupu) średnia FROM egzemplarze e
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
WHERE YEAR(e.data_urodzenia) % 2 = 0
10
SELECT round(AVG(f.cena_wykupu),2) średnia FROM egzemplarze e
JOIN futrzaki f ON f.id_futrzaka = e.id_futrzaka
WHERE YEAR(e.data_urodzenia) % 4 != 0 or YEAR(e.data_urodzenia) % 400 != 0 AND YEAR(e.data_urodzenia) % 100 = 0;








