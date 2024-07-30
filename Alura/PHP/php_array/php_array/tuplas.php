<?php

$dados = [
    'nome' => 'humberto',
    'nota' =>10,
    'idade' => 21
];

//list('nome'=>$nome,'nota' => $nota, 'idade'=> $idade ) = $dados;
//pega o array e separa as variaveis
extract($dados);
var_dump($nome,$nota,$idade);

//transforma variavel em array
var_dump(compact('nome','nota','idade'));