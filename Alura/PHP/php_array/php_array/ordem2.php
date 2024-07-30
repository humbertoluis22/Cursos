<?php

$notas = [
    [
    'aluno' => 'humberto',
    'nota' => 9
    ],
    [
    'aluno' => 'beatriz',
    'nota' => 10
    ],
    [
    'aluno' => 'renato',
    'nota' => 8
    ]
];

// se o primeiro parametro precisar vim antes no array ordenado necessario q o retorno seja menor do que zero -1
// maior do zero se o segundo parametro precisar vim em primeiro

function ordenaNotas (array $nota1, array $nota2)
{
    return $nota2['nota'] <=> $nota1['nota'];

    // if($nota1['nota'] > $nota2['nota']){
    //     return -1;
    // }
    // if($nota1['nota'] < $nota2['nota']){
    //     return 1;
    // }
    // return 0;

}

usort($notas, 'ordenaNotas');
var_dump($notas);
