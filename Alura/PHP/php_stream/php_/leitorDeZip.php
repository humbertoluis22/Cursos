<?php 


$contexto = stream_context_create([
    'zip' => [
        'password' => '123456'
    ]
    ]);
echo file_get_contents('zip://php_.zip#lista-curso.txt',false,$contexto);