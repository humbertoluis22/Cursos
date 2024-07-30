<?php
use Alura\Banco\Modelo\Endereco;

require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\autoload.php';

$umEndereco= new Endereco('sp','santa delfa','rua qualquer','321b');
$outroEndereco = new Endereco('rj','ouro fino','rua dos diamantes','123b');

echo $umEndereco.PHP_EOL;
echo $outroEndereco.PHP_EOL;


