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
            Console.Write("Digite o valor referente" + " a base do retângulo: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor referente" + " a altura do retângulo: ");
            int a = int.Parse(Console.ReadLine());

            //  int a = 4, b = 6;
      
            int area = b * a;
            int perimetro = a + b + a + b;

            Console.WriteLine("Área: " + area + " Perímetro: " + perimetro);
        }
    }
}
