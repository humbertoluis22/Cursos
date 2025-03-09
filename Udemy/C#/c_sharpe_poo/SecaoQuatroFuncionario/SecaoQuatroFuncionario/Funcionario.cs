using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SecaoQuatroFuncionario
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;

        private Dictionary<string,double> NomeSalario = new Dictionary<string,double>();

        public  void AdicionarFuncionario()
        {
            NomeSalario.Add(Nome, Salario);
        }

        public double MediaSalarial()
        {
            return NomeSalario.Values.Sum() / NomeSalario.Count;
        }

        public override string ToString()
        {
            return ("A empresa contem "  + NomeSalario.Count + 
                " funcionarios e a media salarial é de  R$: " +
                MediaSalarial().ToString("F2"));  
        }
    }
}
