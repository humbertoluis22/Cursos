<?php

$nome = 'humberto luis';

$ehDaMinhaFamilia = str_contains($nome, 'luis');

if($ehDaMinhaFamilia ){
    echo "$nome é da minha familia".PHP_EOL;
}else{
    echo "não é da minha familia".PHP_EOL;
}