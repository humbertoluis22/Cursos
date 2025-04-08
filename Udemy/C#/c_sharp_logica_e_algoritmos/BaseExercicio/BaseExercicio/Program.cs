using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;




namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            string[] horaMinuto = input.Split(' ');

            if(horaMinuto.Length < 4)
            {
                return ;
            }
            
            if(
            int.TryParse(horaMinuto[0],out int primeiraHora) && 
            int.TryParse(horaMinuto[1], out  int primeiroMinuto)&&
            int.TryParse(horaMinuto[2], out int segundaHora)&&
            int.TryParse(horaMinuto[3],out int segundoMinuto)
            )
            {

                int inicio_total = (primeiraHora * 60) + primeiroMinuto;
                int final_total = (segundaHora * 60) + segundoMinuto;

                int duracao_min = (final_total - inicio_total + 1440) % 1440;
                if (duracao_min == 0)
                {
                    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
                    return ;
                }

                int hora = duracao_min / 60;
                int minuto = duracao_min % 60;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minuto} MINUTO(S)");
            }

        }
    }
}