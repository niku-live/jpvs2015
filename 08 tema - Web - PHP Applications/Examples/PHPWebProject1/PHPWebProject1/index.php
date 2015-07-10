<html>
<head>
</head>
<body>
<form action="submit.php" id="test">
<input id="Button1" class="raudonas_mygtukas" type="button" formaction="get" form="test" /><br/>
<?php

echo "Hello World!";
echo "Heloo 2";

$i = 10;
$i++;

$i += 10;
while ($i > 10)
{
   echo "Dabar yra $i</br>";
   echo "<a href='submit.php?id=$i'>Paspausk</a><br/>";
   $i--;
}

if ($i > 9)
{ 
  echo "Daugiau uz 9";
}
else
{
  echo "Maziau uz 9";
}



?>
</form>
</body>
</html>