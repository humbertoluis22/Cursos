<?php 

namespace Alura\Banco\Modelo\Conta;


abstract class Conta
{
    private $titular;
    protected $saldo;
    private static $numeroDeContas = 0;
   


    public function __construct(Titular $titular)
    {
        $this->titular= $titular;
        $this->saldo = 0;
   

        self::$numeroDeContas++;
    }

    public function  __destruct()
    {
        self::$numeroDeContas--;
    }


    public function saca(float $valorASacar){

        $tarifaSaque = $valorASacar * $this-> percentualTarifa();
         
        $valorSaque = $valorASacar + $tarifaSaque;
        if($valorSaque > $this->saldo){
            echo "saldo insuficiente".PHP_EOL;
        }else{
            $this->saldo -= $valorSaque;
        }

    }


    public function deposita(float $valorADepositar):void
    {
        if($valorADepositar < 0){
            echo "valor insuficiente para deposito!".PHP_EOL;
            return;
        }
            $this->saldo += $valorADepositar;
        
    }



    public function recuperaSaldo(){
        return $this-> saldo;
    }

    public function recuperaNomeTitular()
    {
        return $this->titular->recuperaNome();
    }

    public function recuperaCpfTitular():string
    {   
       return $this->titular->recuperaCpf();
    }



    public static function recuperaNumeroDeContas():int
    {
        return self::$numeroDeContas;
    } 
 
    abstract protected function percentualTarifa(): float;
    

}

