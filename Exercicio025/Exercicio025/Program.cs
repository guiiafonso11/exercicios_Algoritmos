using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio025
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da base (b): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o tamanho da altura (h): ");
            int h = int.Parse(Console.ReadLine());

            double area = b * h / 2;

            Console.WriteLine("Área do triângulo retângulo: " + area);
            Console.Read();
        }
    }
}
