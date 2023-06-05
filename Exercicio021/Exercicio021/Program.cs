using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio021
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a Primeira Nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Primeira Nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Primeira Nota: ");
            double nota3 = double.Parse(Console.ReadLine());         

            Console.Write("Digite a Primeira Nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double mediap = ((nota1 * 3) + (nota2 * 5) + (nota3 * 6) + (nota4 * 6))
                / (3 + 5 + 6 + 6);

            Console.WriteLine("Média Ponderada: " + mediap);


            Console.WriteLine((mediap >= 6.00) ? "Aprovado" : "Reprovado");
        }
    }
}
