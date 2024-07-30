<?php

$notasBimestre1=[
    'vinicius' =>10,
    'amanda' => 8,
    'rafael' => 7,
    'clarice' => 6,
    'jose' => 5
];

$notasBimestre2=[
    'vinicius' =>9,

    'rafael' => 6,
    'clarice' => 6,

];

// var_dump(array_diff_key($notasBimestre1,$notasBimestre2));
// var_dump(array_diff($notasBimestre1,$notasBimestre2));
// var_dump(array_diff_assoc($notasBimestre1,$notasBimestre2));

$alunosFaltante = array_diff_key($notasBimestre1,$notasBimestre2);
// var_dump(array_keys($alunosFaltante));
// var_dump(array_values($alunosFaltante));

$nomeAlunos = array_keys($alunosFaltante);
$notasAlunos = array_values($alunosFaltante);

var_dump(array_combine($nomeAlunos,$notasAlunos));
var_dump(array_flip($alunosFaltante));