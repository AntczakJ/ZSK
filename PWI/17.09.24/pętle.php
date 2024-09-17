<?php 

for($i = 0; $i < 10; $i++){
    echo 2*$i;
}

echo "<br>"."<br>";

for($i = 0, $k = 5; $i<10; $i++, $k+=3){
    echo $k;
}

echo "<br>"."<br>";

for($p = 1 ;; $p++){
    echo $p;
    if($p == 7){
        break;
    }
}

echo "<br>"."<br>";

$i = 0;
while($i < 10){
    echo $i. " ";
    $i++;
}


echo "<br>"."<br>";

$p = 1;
while(1){
    echo $p;
    if($p == 7) break;
    $p++;
}

echo "<br>"."<br>";


$i = 0;
do{
    echo $i;
    $i++;
}while($i<10);

echo "<br>"."<br>";

$array = array(1, 2, 3, 4);
echo $array. "<br>";
foreach($array as $index){
    echo $index;
}

?>