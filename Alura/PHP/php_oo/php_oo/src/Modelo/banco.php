<?php
namespace Alura\Banco\Modelo;


/*
require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\Conta\Conta.php';
require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\Cpf.php';
require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\Endereco.php';
require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\Pessoa.php';
require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\Conta\Titular.php';
*/


require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\autoload.php';

use Alura\Banco\Modelo\Conta\Titular;
use Alura\Banco\Modelo\Endereco;
use Alura\Banco\Modelo\Cpf;
use Alura\Banco\Modelo\Conta\Conta;
use Alura\Banco\Modelo\Conta\ContaCorrente;
use Alura\Banco\Modelo\Conta\ContaPoupanca;
use Alura\Banco\Modelo\Pessoa;

$endereco = new Endereco('cidade','bairro qualquer','uma rua','302b');
$humberto = new Titular(new Cpf('111.111.111-11'),'humberto',$endereco);
$primeiraConta = new ContaCorrente($humberto);
$primeiraConta ->deposita(500);
$primeiraConta -> saca(100);

echo $primeiraConta -> recuperaNomeTitular().PHP_EOL;
echo $primeiraConta -> recuperaCpfTitular().PHP_EOL;
echo $primeiraConta -> recuperaSaldo().PHP_EOL;

//$segundaConta = new Conta($titular);
//var_dump($segundaConta);

echo Conta::recuperaNumeroDeContas();