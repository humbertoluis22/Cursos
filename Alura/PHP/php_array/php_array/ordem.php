<?php

$notas=[
    10,
    8,
    9,
    7
];


$notasOrdenadas = $notas;
sort($notasOrdenadas);

echo "listas desordenadas: ".PHP_EOL;
var_dump($notas);

echo"listas ordenadas: ".PHP_EOL;
var_dump($notasOrdenadas);