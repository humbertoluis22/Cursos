<?php
 
 //sobre escreve o arquivo q ja existe
 
/*
 $arquivo = fopen("cursos-php.txt",'w');
 $curso = 'treinamento de entrada e saida de arquivo em php';
 */



// para adicionar um arquivo ao final de um  ja existente precisa trocar o modo de inicialização
//exemplo 
/*
$arquivo = fopen("cursos-php.txt",'a');
$curso = "\nsegunda parte do treinamento de entrada e saida de dados em php";
*/

//para criar o arquivo e incluir 
/*
fwrite($arquivo,$curso);

 fclose($arquivo);
 */




 //$curso ='treinamento de entrada e saida de arquivo em php';
 $curso ="\nsegunda parte do treinamento de entrada e saida de dados em php";
 file_put_contents("cursos-php.txt",$curso,FILE_APPEND);