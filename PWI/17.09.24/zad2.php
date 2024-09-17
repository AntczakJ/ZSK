<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        td{
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <?php 
    //ZAD7
echo "<br>";
echo "<table>";
for ($i = 0; $i < 2; $i++)
{
    echo "<tr><td>a</td><td>a</td><td>a</td><td>a</td><td>a</td><td>a</td><td>a</td><td>a</td><td>a</td><td>a</td></tr> ";
}
echo "</table>";


echo "<br>"."<br>";
for ($i = 0; $i < 2; $i++)
{
    for($j = 0; $j < 10; $j++){
        echo "a ";
    }
    echo "<br>";
}

echo "<br>";
echo "<br>";


$l = 0;
for($i = 0; $i<=10;$i++){
    $l++;
}
echo $l;


    ?>
</body>
</html>