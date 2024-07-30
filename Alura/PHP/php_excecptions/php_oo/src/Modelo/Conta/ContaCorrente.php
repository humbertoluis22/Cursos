<?php

namespace Alura\Banco\Modelo\Conta;

require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Conta\Conta.php';
class ContaCorrente extends Conta
{

    protected function percentualTarifa():float
    {
        return 0.05;
    }

}