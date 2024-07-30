<?php

$idadesList = [19,20,21,23,90,42];

list($humberto,$luisa,$henrique,$maria,$guilherme) = $idadesList;

echo $humberto;

unset($idadesList[2]);
echo $idadesList[2];


$umaIdade = $idadesList[0];

echo "$umaIdade".PHP_EOL;