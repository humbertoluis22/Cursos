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
        'titular' => 'ronaldo',
        'saldo'=> 100
    ]
];

$contasCorrentes['143.765.928-90'] = sacar($contasCorrentes['143.765.928-90'],500);
$contasCorrentes['143.765.958-88'] = sacar($contasCorrentes['143.765.958-88'],500);

$contasCorrentes['143.765.328-70'] = depositar($contasCorrentes['143.765.328-70'],954);


//remover
unset($contasCorrentes['143.765.958-88']);


titularComLetrasMaisculas($contasCorrentes['143.765.928-90']);

// echo "<ul>";
// foreach ($contasCorrentes as $cpf => $conta) {
//     exibeConta($conta);
// }

// echo "</ul>";                                 
?>

<!DOCTYPE html>
<html lang = "pt-br">

<head>
    <meta charset="UTF-8">
    <title><strong>banco</strong> </title>
</head>

<body>
    <h1>Contas Correntes</h1>

    <d1>
        <?php foreach($contasCorrentes as $cpf => $conta){ ?>
        <dt>
            <h3><?php echo $conta['titular']; ?> - <?php echo $cpf;?> </h3>
        </dt>
        <dd>
           <?=  'Saldo:'. $conta['saldo'] ?>;
        </dd>
        <?php } ?>
    </d1>

</body>
</html>



