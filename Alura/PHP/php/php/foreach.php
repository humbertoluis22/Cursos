<?php

$contasCorrentes = [
    '143.765.928-90' => [
        'titular' => 'Humberto',
        'saldo' => 1550
    ],
    '143.765.958-88' =>[
        'titular' => 'renato',
        'saldo' => 1700
    ],
    '143.765.328-70' =>  [
        'titular' => 'guilherme',
        'saldo'=> 10000
    ]
];

$contasCorrentes['123.432.987-04'] = [
    'titular' => 'maria',
    'saldo' => 15000
];

foreach ($contasCorrentes as $cpf => $conta) {
    echo $conta['titular'].PHP_EOL;
    echo $cpf.PHP_EOL;
}

                                  