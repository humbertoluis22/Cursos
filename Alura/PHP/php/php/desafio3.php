<?php

$peso = 180;
$altura = 1.73;
$imc = $peso / $altura ** 2;

ECHO"seu imc é $imc ".PHP_EOL;

if($imc  < 30){
    echo"pré-obesidade".PHP_EOL;
}

elseif ($imc  < 35 ){
    echo"obesidade grau1".PHP_EOL;
}

elseif($imc  < 40 ){
    echo"obesidade gra2".PHP_EOL;
}
else{
    echo"obesidade grau3".PHP_EOL;
}