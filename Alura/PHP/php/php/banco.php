<?php
//incluide extensaõ para outro arquivo não obrigatorio
// require extenao obrigatoria, caso não encotre apresenta erro
//require_once verifica se o arquivo ja foi incluido 

//include ('funcoes.php');

require_once 'funcoes.php';

$contasCorrentes = [
    '143.765.928-90' => [
        'titular' => 'Humberto',
        'saldo' => 1550
    ],
    '143.765.958-88' =>[
        'titular' => 'renato',
        'saldo' => 300
    ],
    '143.765.328-70' =>  [
        'titular' => 'guilherme',
        'saldo'=> 100
    ]
];

$contasCorrentes['143.765.928-90'] = sacar($contasCorrentes['143.765.928-90'],500);
$contasCorrentes['143.765.958-88'] = sacar($contasCorrentes['143.765.958-88'],500);

$contasCorrentes['143.765.328-70'] = depositar($contasCorrentes['143.765.328-70'],954);


//remover
unset($contasCorrentes['143.765.958-88']);


titularComLetrasMaisculas($contasCorrentes['143.765.928-90']);

foreach ($contasCorrentes as $cpf => $conta) {
    ['titular' => $titular , 'saldo' => $saldo]= $conta;
    exibeMensagem(
        "$cpf $titular $saldo"
    );
    
    //        "$cpf {$conta['titular']}  {$conta['saldo']}"
}

                                  
