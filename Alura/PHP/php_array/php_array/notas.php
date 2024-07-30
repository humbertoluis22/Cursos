<?php

$notas=[
    'vinicius' =>null,
    'amanda' => 8,
    'rafael' => 7,
    'clarice' => 6,
    'jose' => 5
];


krsort($notas); //ordena pela chave de forma afalbetica  // com o r fica de forma decrescente
//arsort($notas);  //ordena de ordem decrescente e mantem a chave
// rsort($notas);
var_dump($notas);

// if( gettype($notas) === 'array'){
//     echo "sim é um array".PHP_EOL;
// }


if(is_array($notas)){
    echo "sim é um array".PHP_EOL;
}


//se for um array numerico
var_dump(array_is_list($notas));

//se uma chave existe dentro de um array
echo 'vinicius fez  a prova: '.PHP_EOL;
var_dump( array_key_exists('vinicius',$notas));

//verifica se na chave tem um array nulo isset

echo "valor nulo: ".PHP_EOL;
var_dump(isset($notas['vinicius']));

//se um valor existe em um array

echo "alguem tirou 10: ".PHP_EOL;
var_dump(in_array(10,$notas));


echo "quem tirou 10: ".PHP_EOL;
echo array_search(10,$notas);

// array_key_exists = se uma chave existe 
//in_array = se o valor existe
//isset = se a chave existe e não  é nulo

