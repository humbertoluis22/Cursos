<?php

$meusCursos = file('lista-cursos.txt');
$outroCursos = file('cursos-php.txt');

$arquivosCsv = fopen('cursos.csv','w');

foreach ($meusCursos as $curso)
{
    $linha = [trim(utf8_decode($curso)), 'Sim'];

    fputcsv($arquivosCsv,$linha,';');
    
    //fwrite($arquivosCsv,implode(',',$linhas));
}

foreach ($outroCursos as $cursos){
    $linha = [trim(utf8_decode($curso)), 'Não'];
    fputcsv($arquivosCsv,$linha,';');
}

fclose($arquivosCsv);