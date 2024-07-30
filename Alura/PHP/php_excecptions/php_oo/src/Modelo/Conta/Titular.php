<?php 


namespace Alura\Banco\Modelo\Conta;

use Alura\Banco\Modelo\Autenticavel;
use Alura\Banco\Modelo\Pessoa;
use Alura\Banco\Modelo\Cpf;
use Alura\Banco\Modelo\Endereco;

require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\autoload.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Pessoa.php';
require_once 'C:\Users\Humberto\Desktop\php\php_excecptions\php_oo\src\Modelo\Autenticavel.php';
class Titular extends Pessoa implements Autenticavel
{
    private $endereco;

    public function __construct(Cpf $cpf, string $nome,Endereco $endereco )
    {
        parent :: __construct($nome,$cpf);
        $this->endereco = $endereco;
    }



    public function recuperaEndereco(): Endereco
    {
        return $this->endereco;
    }

    public function podeAutenticar(string $senha):bool
    {
        return $senha === 'abcd';
    }
    
}