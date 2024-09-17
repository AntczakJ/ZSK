<?php 

$i = 1;
do{
    echo $i;
    if($i>=10) break;
    $i++;
}while(true);

echo "<br>"."<br>";

$i = 10;
do{
    echo $i. "<br>";
    if($i==0) break;
    $i--;
}while(true);

echo "<br>"."<br>";

for($i = 1, $p = 2;$i < 10;$i++, $p++){
    echo $i. " i ". $p. "<br>";
    echo $i + $p. "<br>";
}

echo "<br>"."<br>";

$r = 2024; 
if($r % 4 == 0 || $r % 400 == 0 && $r % 100 != 0){
    echo "29 dni". "<echo>";
}
else{
    echo "28 dni". "<echo>";
}

echo "<br>"."<br>";









?>