using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio049
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número. (menor que 10)");
            int num = int.Parse(Console.ReadLine());

            if(num < 10)
            {
                while (num >= 20)
                {
                    Console.Write(num + "|");
                    num--;
                }

            }
            else
            {
                Console.Write("Digite um valor válido!");
            }

        }
    }
}
