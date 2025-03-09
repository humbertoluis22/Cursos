using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecaoCincoProduto
{
    internal class Produto
    {
        private string _nome;
        private double Valor
        {
            get { return Valor; }
            set { Valor = value; }
        }
        private int Quantidade
        {
            get { return Quantidade; }
            set { Quantidade = value;  }
        }


        public Produto(){ 
            Quantidade = 0;
        }

        public Produto(string nome,double valor,int quantidade):this()
        {
            this._nome = nome;
            this.Valor = valor;
            this.Quantidade = quantidade;  
        }

        //properties
        public string Nome
        {
            set { 
                if(value != null && value.Length >= 2 )
                {
                    _nome = value;
                }
            }
            get { return _nome; }
        }

        public override string ToString()
        {
            return "O produto " + _nome 
                + " tem " + Quantidade + " unidades no estoque " 
                + " e o valor que temos  de estoque é R$ : " 
                + MediaProdutos().ToString("F2");
        }

        public void AdicionarQuantidadeProduto(int quantidade)
        {
            if(quantidade > 0)
            {
                this.Quantidade += quantidade;
            }
        }

        public void RemoverQuantidadeProduto(int quantidade)
        {
            if(quantidade > 0 && quantidade <= this.Quantidade)
            {
                this.Quantidade -= quantidade;
            }
        } 

        public double MediaProdutos()
        {
            return this.Quantidade * this.Valor;
        }
    }
}
