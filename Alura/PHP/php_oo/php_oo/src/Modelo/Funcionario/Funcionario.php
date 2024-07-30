<?php

namespace Alura\Banco\Modelo\Funcionario;
use Alura\Banco\Modelo\Cpf;
use Alura\Banco\Modelo\Pessoa;

abstract class Funcionario extends Pessoa
{
     private $salario;

    public function __construct(string $nome,Cpf $cpf,float $salario)
    {
        parent:: __construct($nome,$cpf);
        $this -> salario = $salario;

    }



    public function  alteraNome(string $nome):void
    {
        $this->validaNomeTitular($nome);
        $this-> nome = $nome;
    }

    public function  recebeAumento(float $valorAumento):void
    {
        if($valorAumento < 0){
            echo 'valor do aumento deve ser positivo';
            return;
        }
        $this->salario += $valorAumento;
    }


    public function recuperaSalario()
    {
        return $this-> salario;
    }

    abstract public function calcularBonificacao():float;
   
}