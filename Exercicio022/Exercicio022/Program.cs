using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double num3 = double.Parse(Console.ReadLine());

            double mediaArit = ((num1 + num2 + num3)) / 3;

            Console.WriteLine("Média Aritmédica: " + mediaArit);

        }
    }
}
