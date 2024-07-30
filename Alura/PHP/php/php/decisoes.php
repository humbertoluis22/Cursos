<?php

$idade = 17;
$numeroDePessoas =1;

echo "vc só pode entrar se tiver a partir de 18 anos".PHP_EOL;
echo " E a partir de 16 anos somente acompanhado".PHP_EOL;

if($idade >= 18 ){
    echo "voce tem $idade anos".PHP_EOL;
    echo "voce pode entrar".PHP_EOL;
}
elseif($idade >= 16 && $idade < 18 && $numeroDePessoas > 1){
    echo "você não tem 18 anos ";
    echo "mas pode entrar pois esta em $numeroDePessoas pessoas".PHP_EOL;
}
else{
    echo "voce só tem $idade. Voce não pode entrar".PHP_EOL;
}

echo PHP_EOL;
echo "adeus".PHP_EOL;