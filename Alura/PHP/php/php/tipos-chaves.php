<?php

//php só entende como chave em array string e inteiro, qualquer outro valor ele tenta converter ou aproximar 
//php sob escreve
$array=[
    1 => 'a',
    '1' => 'b',
    1.5 => 'c',
    true => 'd'
];

foreach ( $array as $item){
    echo $item.PHP_EOL;
}