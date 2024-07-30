<?php

//depois que o primeiro parametro for modificado, na segunda chamada ele nao sera sobreposto
$trans = array("h" => "-", "hello" => "hi", "hi" => "hello");
echo strtr("hi all, I said hello", $trans).PHP_EOL;

//substitui todos os parametros, independente se ja foi modificado
echo str_replace(['hello','hi'],['hi','hello'],"hi all, I said hello").PHP_EOL;


