<?php

$alunos2022 = [
    0 =>'vinicius' ,
    1 =>'amanda' ,
    2 =>'rafael' ,
    3 =>'clarice' ,
    4 =>'jose' 
];

$novosAlunos = [
    5 =>'patricia',
    6 =>'guilherme',
    7 =>'isabella'
];

$alunos2023 =[...$alunos2022,'humberto luis',...$novosAlunos];
//adicionando alunos
array_push($alunos2023,'alice','gabriela','josue');
$alunos2023[]='luis';

array_unshift($alunos2023,'mariaa');

//removendo
//1posicao
echo array_shift($alunos2023).PHP_EOL;
echo array_pop($alunos2023).PHP_EOL;

var_dump($alunos2023); 