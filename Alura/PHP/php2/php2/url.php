<?php

$url = 'https://alura.com.br';

if(str_starts_with($url,'https')){
    echo "é uma url segura".PHP_EOL;
}else{
    echo "não é uma url segura".PHP_EOL;
}


if(str_ends_with($url,'br')){
    echo"é um dominio do brasil".PHP_EOL;
}else{
    echo "não é um dominio do brasil".PHP_EOL;
}