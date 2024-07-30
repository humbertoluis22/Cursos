<?php 

function mensagem (string $mensagem)
{
    echo $mensagem.PHP_EOL;
}

function sacar(array $conta, float $valorSaque)
{
    if($valorSaque > $conta['saldo']){
        mensagem('Voce não possui saldo suficiente para efetuar o saque!!');
    }else{
        $conta['saldo'] -= $valorSaque;
    }
    return $conta;
}


function depositar(array $conta, float $valorDeposito){
    if($valorDeposito > 0){
        $conta['saldo'] += $valorDeposito;
    }else{
        mensagem('valor do deposito necessita ser positivo!!');
    }
    return $conta;
}


$contasBancarias = [
    '432.543.754-65' => ['titular' => 'Isabella', 'saldo' => 100],
    '454.543.653-53' => ['titular' => 'maria', 'saldo' => 200] 
];

$contasBancarias['867.423.654-23'] = ['titular' => 'guilherme', 'saldo' => 320];


$contasBancarias['432.543.754-65'] = sacar($contasBancarias['432.543.754-65'],300);
$contasBancarias['454.543.653-53']= sacar($contasBancarias['454.543.653-53'],100);

$contasBancarias['867.423.654-23'] = depositar($contasBancarias['867.423.654-23'],200);

foreach( $contasBancarias as $cpf => $conta ){
    mensagem($cpf. " ". $conta['titular']. " ". $conta['saldo']);
}