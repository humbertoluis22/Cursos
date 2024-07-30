<?php

$texto= 'texto com qualquer coisa, poxa e caramba';

echo str_replace(
    ['poxa','caramba'],
    '***',
    $texto
    ).PHP_EOL;


// FUNÇAO QUE TRABALHA COM CARACTERES E NAO COM STRINGS COMO NO EXEMPLO DE CIMA

echo strtr($texto, 'poxa','***@').PHP_EOL;

//um array para mostrar o que vc quer substituir e pelo oq
echo strtr($texto,['poxa' => '****', 'caramba' => '@@@@']).PHP_EOL;

$nome = 'humberto luís';

echo str_replace('í','i',$nome).PHP_EOL;