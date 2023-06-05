using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine());

            double areaCirc = 3.14 * Math.Pow(raio, 2);
            double areaMenor = 3.14 * raio;

            double areaGeral = areaCirc - areaMenor;

            Console.WriteLine("Área Geral: " + areaGeral);
         
        }
    }
}
