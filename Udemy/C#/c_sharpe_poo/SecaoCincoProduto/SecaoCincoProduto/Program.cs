using SecaoCincoProduto;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o nome do Produto : ");
            string nome = Console.ReadLine();

            Console.Write("Informe o valor do Produto : ");
            double valor = double.Parse(Console.ReadLine());
         
            Console.Write("Informe A quantidade de Produto : ");
            int quantidade = int.Parse(Console.ReadLine());
                
            Produto produto = new Produto(nome,valor,quantidade);
            

            Console.WriteLine(produto);
            Console.WriteLine();

            Console.Write("Informe A quantidade  de Produto  a adicionar  : ");
            int adicionarQuantidade = int.Parse(Console.ReadLine());
            produto.AdicionarQuantidadeProduto(adicionarQuantidade);
            Console.WriteLine(produto);

            Console.Write("Informe a quantidade de Produto a remover : ");
            int removerQuantidade = int.Parse(Console.ReadLine());
            produto.RemoverQuantidadeProduto(removerQuantidade);

            Console.WriteLine(produto);

        }
    }
}