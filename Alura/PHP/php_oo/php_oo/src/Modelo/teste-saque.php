<?php

use Alura\Banco\Modelo\Conta\Conta;
use Alura\Banco\Modelo\Endereco;
use Alura\Banco\Modelo\Conta\Titular;
use Alura\Banco\Modelo\Cpf;


require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\autoload.php';

$conta = new Conta(new Titular(new Cpf('111.111.111-22'),
'humberto',
new Endereco('sp','bairro teste', 'rua la','23'))
);

$conta -> deposita(500);
$conta -> saca(100);

echo $conta -> recuperaSaldo();