using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());
            int peso1 = 1;

            Console.WriteLine("Digite a segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            int peso2 = 2;

            Console.WriteLine("Digite a terceiro número: ");
            double num3 = double.Parse(Console.ReadLine());
            int peso3 = 3;

            Console.WriteLine("Digite a quarto número: ");
            double num4 = double.Parse(Console.ReadLine());
            int peso4 = 4;

            double mediap = (num1 * peso1) + (num2 * peso2) + (num3 * peso3) + (num4 * peso4) / (peso1 + peso2 + peso3 + peso4);

            Console.WriteLine(mediap);
        }
    }
}
