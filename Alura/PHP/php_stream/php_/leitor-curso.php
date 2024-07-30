<?php
//abrir o arquivo
//$arquivo = fopen('lista-curso.txt','r');

//ler linha a linha
/*
while(!feof($arquivo))
{
    $curso = fgets($arquivo);
    echo $curso;

}
*/


// ler o tamanho do arquivo e depois ler ele todo
/*
$tamanhoDoArquivo = filesize('lista-curso.txt');
$curso = fread($arquivo,$tamanhoDoArquivo);
echo $curso;
*/


//fechar a leitura do arquivo
//////fclose($arquivo);


//uma funçao que faz a leitura, abre o arquivo e fecha
$t = file_get_contents('lista-curso.txt');
echo $t;

//a cada linha lida vira um indice de uma array
$a = file('lista-curso.txt');
var_dump($a);