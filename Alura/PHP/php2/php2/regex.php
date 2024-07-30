<?php
//expressao regulares
$telefones = ['(11) 99999-9999','(11) 99999-9999','(11) 99999-9999'];

foreach($telefones as $telefone){
    $telefoneValido = preg_match(
        '/^\([0-9]{2}\) 9?[0-9]{4}-[0-9]{4}$/',
        $telefone,
        $correspondencia
    );
    if($telefoneValido){
        echo 'telefone valido'.PHP_EOL;
    }else{
        echo 'telefone invalido'.PHP_EOL;
    }


    echo preg_replace(
        '/^\(([0-9]{2}\)) (9?[0-9]{4}-[0-9]{4})$/',
        '(xx) \2',
        $telefone
    ).PHP_EOL;
}