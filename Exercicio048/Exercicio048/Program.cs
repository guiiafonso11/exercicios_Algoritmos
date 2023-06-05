using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if(num >= 0)
            {
                while(num >= 0)
                {
                    Console.Write(num + "|" );
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
