using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a área da base: ");
            double area = double.Parse(Console.ReadLine());
            double areaCirc;

            Console.Write("Digite a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = area * altura;

            Console.WriteLine("Volume: " + volume);
            

        }
    }
}
