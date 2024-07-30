<?php

$conta1 =[
    'titular' => 'Humberto',
    'saldo' => 1550
];

$conta2 = [
    'titular' => 'renato',
    'saldo' => 1700
];

$conta3 = [
    'titular' => 'guilherme',
    'saldo'=> 10000
];

$contasCorrentes = [$conta1 , $conta2 ,$conta3];

for($i=0 ; $i < count($contasCorrentes); $i ++){
    echo $contasCorrentes[$i]['titular'].PHP_EOL;
}