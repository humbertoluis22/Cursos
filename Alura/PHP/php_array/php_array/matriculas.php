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

// $alunos2023 = array_merge($alunos2022,$novosAlunos);

//com o operador mais , ele sao sobescreve ou seja, só é adicionando os arrays q nao tiver o indice no de cima
//$alunos2023 = $alunos2022+$novosAlunos;

//desempacotador  unpacking operador
$alunos2023 =[...$alunos2022,'humberto luis',...$novosAlunos];
var_dump($alunos2023); 

//spread operador

function funcao (array ...$alunos){

}