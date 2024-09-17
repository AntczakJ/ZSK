<?php 

$t = array(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
///foreach($t as $index){
//echo $index. " ";
//}
print_r($t);

for($i = 0;$i<count($t);$i++){
    echo $t[$i];
}

$tab = array();
for($i = 0; $i < 10; $i++){
    $tab[$i] = $i+1;
}
for($i=0; $i<count($tab);$i++){
    echo $tab[$i]. ' ';
}

?>