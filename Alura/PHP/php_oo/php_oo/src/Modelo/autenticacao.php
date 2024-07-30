<?php

use Alura\Banco\Modelo\Conta\Titular;
use Alura\Banco\Modelo\Cpf;
use Alura\Banco\Modelo\Endereco;
use Alura\Banco\Modelo\Funcionario\Diretor;
use Alura\Banco\Modelo\Funcionario\Gerente;
use Alura\Banco\Service\Autenticador;

require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\autoload.php';


$autenticador = new Autenticador();
$umDiretor = new Gerente('rogerio',
    new Cpf('123.342.543-12'),
    10000);


$umTitular = new Titular(
    new Cpf('111111111'),
    'maria',
    new Endereco('sp','parque sd','qualquer','231')
);
$autenticador->tentaLogin($umDiretor,'4321').PHP_EOL;
$autenticador->tentaLogin($umTitular,'abcd').PHP_EOL;