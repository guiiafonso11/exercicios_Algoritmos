using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = 4 * 3.14 * Math.Pow(raio, 2);
            double volume = 4 / 3 * 3.14 * Math.Pow(raio, 3);

            Console.WriteLine("Área: " + area + "\n" + "Volume: " + volume);
        }
    }
}
