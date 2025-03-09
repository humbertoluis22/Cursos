
using System;
using System.Globalization;
namespace Strings
{
    internal class Strings
    {
        static void Main(string[] args)
        {

            Console.Write("Digite 3 frutas separadas por espaço : ");
            string frutas = Console.ReadLine();

            string[] vetorDeFrutas = frutas.Split();

            string primeiraFruta = vetorDeFrutas[0];
            string segundaFruta = vetorDeFrutas[1];
            string terceiraFruta = vetorDeFrutas[2];

            Console.WriteLine("Primeira fruta : " + primeiraFruta);
            Console.WriteLine("segunda fruta : " + segundaFruta);
            Console.WriteLine("terceira fruta : " + terceiraFruta);

            Console.Write("Digite um numero double : ");
            double numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //porem deixa de reconher o separador por virgula, entao é mais pelo jeito que preferir
            Console.WriteLine("numero separado por ponto com sistema br : " + numero);

            Console.Write("Digite o nome do paciente sexo altura e peso separados por espaço: ");
            string descritivoCompleto = Console.ReadLine();

            string[] vetoresDoDescritivo = descritivoCompleto.Split(' ');
            string nome = vetoresDoDescritivo[0];
            char sexo = char.Parse(vetoresDoDescritivo[1]);
            double altura = double.Parse(vetoresDoDescritivo[2],CultureInfo.InvariantCulture);
            double peso = double.Parse(vetoresDoDescritivo[3],CultureInfo.InvariantCulture);

            Console.WriteLine("Nome informado : "+ nome);
            Console.WriteLine("Sexo informado : " + sexo);
            Console.WriteLine("Altura informada : " + altura.ToString("F2"));
            Console.WriteLine("Peso informado : " + peso.ToString("F2"));

        }
    }
}
