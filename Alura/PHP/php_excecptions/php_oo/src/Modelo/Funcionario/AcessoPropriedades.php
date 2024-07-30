<?php
namespace Alura\Banco\Modelo\Funcionario;

trait AcessoPropriedades
{
    public function __get(string $nomeAtributo)
    {
        $metodo= 'recupera'.ucfirst($nomeAtributo);
        return $this->$metodo;
    }
}