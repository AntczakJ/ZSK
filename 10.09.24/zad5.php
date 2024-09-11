<?php 
$m = 100;

switch ($m) {
    case $m < 30:
        echo "ndst";
        break;
    case $m < 60 && $m > 30:
            echo "dop";
            break;
    case $m < 80 && $m > 60:
        echo "dst";
        break;
    case $m < 90 && $m > 80:
        echo "bdb";
        break;
    case $m == 100:
        echo "cel";
        break;
    
}
?>