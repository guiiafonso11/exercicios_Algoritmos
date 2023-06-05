using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de h: ");
            double h = double.Parse(Console.ReadLine());

            double area = (B + b) * h / 2;

            Console.WriteLine("Área: " + area);

        }
    }
}
