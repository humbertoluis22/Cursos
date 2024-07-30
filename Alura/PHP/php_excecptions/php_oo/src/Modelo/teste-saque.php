<?php
use Alura\Banco\Modelo\Conta\ContaPoupanca;

use Alura\Banco\Modelo\Conta\Titular;
use Alura\Banco\Modelo\Cpf;
use Alura\Banco\Modelo\Endereco;


require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\autoload.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Conta\Conta.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Conta\ContaPoupanca.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Conta\Titular.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Cpf.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Endereco.php';

$conta1 = new ContaPoupanca(new Titular
(new Cpf('111.111.111-22'),
'humberto',
new Endereco('sp','bairro teste', 'rua la','23'))
);

$conta1 -> deposita(500);
$conta1 -> saca(600);

echo $conta1 -> recuperaSaldo();