<?php



function teste():void{
$string = <<<FINAL

    UMA LINHA
    OUTRA LINHA
    MAIS UMA LINHA

    FINAL;

echo $string.PHP_EOL;
}

teste();


//não aceita variavel na sintaxe nowdoc
function geraEmail():void{
    $conteudoEmail = <<<'FIM'
    olá, fulano(a)! $nome

    estamos entrando em contado para
    {motivo do contato}

    {assinatura}
    FIM;

    ECHO $conteudoEmail.PHP_EOL;
}

geraEmail();



