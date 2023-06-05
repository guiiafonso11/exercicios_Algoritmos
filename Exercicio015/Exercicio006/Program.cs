using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o lado A do perímetro: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B do perímetro: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C do perímetro: ");
            double c = double.Parse(Console.ReadLine());

            double volume = a * b * c;


            Console.WriteLine("Volume: " + volume);


        }
    }
}
