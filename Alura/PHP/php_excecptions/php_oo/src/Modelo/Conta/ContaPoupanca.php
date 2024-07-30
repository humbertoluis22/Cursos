<?php

namespace Alura\Banco\Modelo\Conta;

class ContaPoupanca extends Conta
{
     /*
     public function saca(float $valorASacar):void
     {
       
       $tarifaSaque = $valorASacar * 0.03;
        $valorSaque = $valorASacar + $tarifaSaque;
        if($valorSaque > $this->saldo){
             echo "saldo insuficiente".PHP_EOL;
            return;
            }
            $this->saldo -= $valorSaque;
        }
            */


        protected function  percentualTarifa():float
        {
            return 0.03;
        }

        
    public function transfere(float $valorAtransferir , Conta $contaDestino):void
    {
        if($valorAtransferir > $this-> saldo){
            echo "valor indisponivel";
        }else{
            $this->saca($valorAtransferir);
            $contaDestino ->deposita($valorAtransferir);
        }

    }


}
