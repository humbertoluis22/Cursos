using System;
using System.Globalization;
using System.Collections.Generic;


class URI
{

    static void Main(string[] args)
    {

        double NotaEntrada = double.Parse(Console.ReadLine());
        List<double> cedulas = new List<double> { 100.0, 50.0 ,20.0,10.0,5.0,2.0 };
        List<double> moedas = new List<double> { 1.0, 0.50, 0.25, 0.10, 0.05, 0.01 };

        List<List<double>> valores = new List<List<double>>{cedulas,moedas};
        List<string> descritivos = new List<string>{"NOTAS:","MOEDAS:"};


        double restoNota = 0.0;
        int contador = 1;
        for (int i = 0; i < 2; i++) 
        { 
            
            Console.WriteLine(descritivos[i]);
            foreach (double cedula in valores[i])
            {
                
                if (contador == 1 && i == 0)
                {
                    double troco = NotaEntrada % cedula;
                    restoNota = troco;
                    int qtdNotas = (int)(NotaEntrada / cedula);
                    Console.WriteLine(qtdNotas + " nota(s) de R$ " + cedula.ToString("F2", new CultureInfo("en-US")));
                    contador++;
                    continue;
                }

                int novaQtdNotas = (int)(Math.Round(restoNota,2 )/ cedula);
                if(i == 0)
                {
                    Console.WriteLine(novaQtdNotas + " nota(s) de R$ " + cedula.ToString("F2", new CultureInfo("en-US")));
                }
                else
                {
                    Console.WriteLine(novaQtdNotas + " moeda(s) de R$ " + cedula.ToString("F2", new CultureInfo("en-US")));
                }
          
                double novoTroco = restoNota % cedula;
                restoNota = novoTroco;
                contador++;
            }

        }
        Console.ReadLine();
    }

}