using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14 * Math.Pow(raio, 2);

            double perimetro = 2 * 3.14 * raio;

            Console.WriteLine("Área: " + area + "\n" + 
                                "Perímetro: " + perimetro);
        }
    }
}
