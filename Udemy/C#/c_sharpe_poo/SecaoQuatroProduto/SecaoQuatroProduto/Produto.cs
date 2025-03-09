using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecaoQuatroProduto
{
    internal class Produto
    {
        public double Valor;
        public int Quantidde;
        public string Nome;

        public double valorEstoque()
        {
            return Quantidde * Valor;
        }

        public void AdicionarQtdProduto(int quantidade)
        {
            Quantidde += quantidade;
        }


        public void RemoverQtdProduto(int quantidade)
        {
            Quantidde -= quantidade;
        }

        public override string ToString()
        {
            return ("Produto : " + Nome + 
                "|  Quantidade em Estoque : " + Quantidde + 
                " | Valor Estoque : R$ " + valorEstoque().ToString("F2"));
        }
    }

}
