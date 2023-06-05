using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("A raiz quadrada de: " + num1 + " é " + Math.Sqrt(num1));
        }
    }
}
