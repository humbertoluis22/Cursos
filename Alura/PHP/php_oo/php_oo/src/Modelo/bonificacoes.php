<?php

require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Modelo\autoload.php';
require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_oo\src\Service\ControladorDeBonificacoes';

use Alura\Banco\Modelo\Cpf;
use Alura\Banco\Modelo\Funcionario\Desenvolvedor;
use Alura\Banco\Modelo\Funcionario\Diretor;
use Alura\Banco\Modelo\Funcionario\EditorVideo;
use Alura\Banco\Modelo\Funcionario\Funcionario;
use Alura\Banco\Modelo\Funcionario\Gerente;
use Alura\Banco\Service\ControladorDeBonificacoes;

$umFuncionario = new Desenvolvedor(
    'humberto luis de oliveira',
    new Cpf('321.312.432-21'),
    5000); 


$umFuncionario-> sobreDeNivel();
$umaFuncionaria = new Gerente(
    'maria',
    new Cpf('111.222.333-21'),
    15000);

$umdiretor = new Diretor(
    'ana paula',
    new Cpf('223.222.333-21'),
    6000);



$umEditor = new EditorVideo(
    'maria',
    new Cpf('333.333.333-33'),
    2000
);


$controlador = new ControladorDeBonificacoes();
$controlador ->adicionaBonificacaoDe($umFuncionario);
$controlador -> adicionaBonificacaoDe($umaFuncionaria);
$controlador ->adicionaBonificacaoDe($umdiretor);
//$controlador->adicionaBonificacaoDe($umEditor);

echo $controlador -> recuperaTotal();