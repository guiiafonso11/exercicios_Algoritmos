using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio039
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário de um funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Salário: " + salario);
            double aumento = 25.0 / 100.0;


            double novoSalario = salario + (aumento * salario);

            Console.WriteLine("Novo salário: " + novoSalario);
        }
    }
}
