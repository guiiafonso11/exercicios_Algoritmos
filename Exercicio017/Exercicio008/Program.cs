using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a área da base: ");
            double area = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do prisma: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = area * altura;

            Console.WriteLine("Volume: " + volume);

        }
    }
}
