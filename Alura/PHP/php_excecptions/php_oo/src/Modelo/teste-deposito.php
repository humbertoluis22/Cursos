<?php

use Alura\Banco\Modelo\Conta\ContaCorrente;
use Alura\Banco\Modelo\Conta\Titular;
use Alura\Banco\Modelo\Cpf;
use Alura\Banco\Modelo\Endereco;

require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Conta\ContaCorrente.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\autoload.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Cpf.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Conta\Titular.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Endereco.php';


$contaCorrente = new ContaCorrente(
    new Titular(
        new Cpf('123.453.123-32'),
        'humberto',
        new Endereco('cidade','bairro','rua','numero')
    )
);

try{
$contaCorrente ->deposita(-100);
}catch( InvalidArgumentException $exception){
    echo "valor a depositar necessita ser positivo";
}