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
            int l1 = 5;
            int l2 = 5;

            int area = l1 * l2;
            int perimetro = l1 + l2 + l1 + l2;


            Console.WriteLine("Área: " +  area + "\n" + "Perímetro: " + perimetro );
        }
    }
}
