<?php

$nome='humberto luís';
$email = '.,.,maria@gmail.com .,.,.,';
$senha = '123ùÌÌ';

$posicaoDoArroba= strpos($email,'@');

echo mb_strlen($senha).PHP_EOL;

if(strlen($senha)< 8){
    echo "senha insegura".PHP_EOL;
}

$usuario = substr($email,0,$posicaoDoArroba);

// echo substr($email,0,$posicaoDoArroba).PHP_EOL;

echo mb_strtoupper($usuario).PHP_EOL;
echo strtolower($usuario).PHP_EOL;
echo substr($email,$posicaoDoArroba +1).PHP_EOL;

list($nome , $sobrenome) = explode(' ',$nome);

echo "nome: $nome".PHP_EOL;
echo "sobre nome: $sobrenome".PHP_EOL;

//remover os espaços mas pode receber um segundo parametro para saber o q vai remover
var_dump(trim($email)).PHP_EOL;
//aparar o lado esquerdo da string
var_dump(ltrim($email, ',.')).PHP_EOL;
//aparar o lado direito da string
var_dump(rtrim($email,'.,')).PHP_EOL;
