<?php

require_once 'C:\Users\Humberto\Desktop\php\php_oo\php_\MeuFIltro.php';
$arquivoCurso = fopen('lista-curso.txt','r');

stream_filter_register('alura.partes', MeuFiltro :: class);
stream_filter_append($arquivoCurso, 'alura.partes');

echo fread($arquivoCurso,filesize('lista-curso.txt'));