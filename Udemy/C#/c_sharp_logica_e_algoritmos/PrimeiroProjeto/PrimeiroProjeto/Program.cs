using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args) {
            double numero_teste = 1.321342432;
            Console.WriteLine(numero_teste);
            Console.WriteLine(numero_teste.ToString("F2"));//  exibindo com apenas duas casas decimais
            Console.WriteLine(numero_teste.ToString("F4")); // exibindo com formatação de 4 digitos

            // testando concatenaçôes
            Console.WriteLine();
            Console.WriteLine("Concatenando string e numero " + numero_teste);
            Console.WriteLine("O valor do produto é R$ : " + numero_teste.ToString("F2") );

            string nomePaciente = "Maria";
            char sexo = 'F';
            int idade = 32;

            Console.WriteLine("A paciente " + nomePaciente + "do sexo " + sexo + " tem " + idade + "anos" );
        }
    }
}
