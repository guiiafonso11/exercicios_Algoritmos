using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio023
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 17;


            Console.WriteLine((num % 2 == 0) ? "Valor: " + num + 
                "\n" + "Elevado ao Quadrado: " + Math.Pow(num, 2) : "Valor: " + num + 
                "\n" + "Elevado ao Cubo: " + Math.Pow(num, 3));

            
            if (num % 2 == 0)
           {
                Console.WriteLine("Valor: " + num);
                Console.WriteLine("Elevado ao Quadrado: " + Math.Pow(num, 2));
            }
            else
            {
                Console.WriteLine("Valor: " + num);
                Console.WriteLine("Elevado ao Cubo: " + Math.Pow(num, 3));
            }

           
        }
    }
}
