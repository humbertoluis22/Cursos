using System;

namespace SecaoQuatroProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.Write("Digite o Nome do Produto: ");
            produto.Nome = Console.ReadLine();
            
            Console.Write("Digite a quantidade de Produto em estoque : ");
            produto.Quantidde = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor do Produto : ");
            produto.Valor = double.Parse(Console.ReadLine());
            
            Console.WriteLine();

            Console.WriteLine(produto);

            Console.Write("Digite a quantidade de Produto a ser adicionado : ");
            int quantidde = int.Parse(Console.ReadLine());
            produto.AdicionarQtdProduto(quantidde);
            Console.WriteLine();
            Console.WriteLine(produto);
            Console.WriteLine();

            Console.Write("Digite a quantidade de Produto a ser removida : ");
            int quantiddeRemover = int.Parse(Console.ReadLine());
            produto.RemoverQtdProduto(quantiddeRemover);
            Console.WriteLine();
            Console.WriteLine(produto);
            Console.WriteLine();
        }
    }
}