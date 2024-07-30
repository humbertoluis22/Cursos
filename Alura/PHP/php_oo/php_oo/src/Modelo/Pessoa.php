<?php 

namespace Alura\Banco\Modelo;


class Pessoa
{
    protected $nome;
    protected $cpf;


    public function __construct(string $nome, Cpf $cpf)
    {
        $this->validaNomeTitular($nome);
        $this -> nome =$nome;
        $this ->cpf =$cpf;
    }

    public function recuperaNome():string
    {
        return $this -> nome;
    }

    public function recuperaCpf():string
    {
        return $this -> cpf ->recuperaNumero();
    }

    final protected function validaNomeTitular( string $nomeTitular)
    {
        if(strlen($nomeTitular) < 5){
            echo "nome precisa conter pelo menos 5 caracteres";
            exit();
        }
    }

}