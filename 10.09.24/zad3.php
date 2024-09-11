<?php 

$a = 5;
$b = 20;
$c = 5;
$d = 7;

if($b != 0)
    echo $a/$b . "<br>";
else
    echo("Nie dzielimy przez 0" . "<br>");

if($b != 0 && $d != 0)
    echo ($a/$b) + ($c/$d) . "<br>";
else
    echo("Nie dzielimy przez 0" . "<br>");

?>