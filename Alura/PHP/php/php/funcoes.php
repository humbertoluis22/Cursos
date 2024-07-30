<?php
//subrotina
function exibeMensagem(string $mensagem){
    echo $mensagem .'<br>';
}

function sacar (array $conta , float $valorASacar): array
{
    if($valorASacar > $conta['saldo']){
        exibeMensagem('voce não pode sacar esse valor!!');
    }else{
        $conta['saldo'] -= $valorASacar;
    }
    return $conta;
}

function depositar(array $conta, float $valorADepositar):array
{
    if($valorADepositar > 0){
        $conta['saldo'] += $valorADepositar;
    }
    else{
        exibeMensagem('depositos precisam ser positivos!!');
    }
    return $conta;
}

function titularComLetrasMaisculas(array &$conta){
    $conta['titular'] = strtoupper($conta['titular']);
}

function exibeConta(array $conta){
    ['titular' => $titular , 'saldo' => $saldo]= $conta;
   ECHO "<li>Titular: $titular. Saldo: $saldo</li>";
}