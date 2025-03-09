using System;

namespace SecaoQuatroFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionario : ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Digite o Salario do primeiro funcionario : ");
            funcionario.Salario = double.Parse(Console.ReadLine());
            funcionario.AdicionarFuncionario();

            Console.WriteLine();

            Console.Write("Digite o nome do segundo funcionario : ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Digite o Salario do segundo funcionario : "); 
            funcionario.Salario = double.Parse(Console.ReadLine());
            funcionario.AdicionarFuncionario();

            Console.WriteLine();
            Console.WriteLine(funcionario);
        }
    }
}