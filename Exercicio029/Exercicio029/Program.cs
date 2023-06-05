using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            double adicao = num1 + num2;

            if (adicao>10)
            {
                Console.WriteLine("Números digitados: " + num1 + "e" + num2 );
                Console.WriteLine("Valor da adição: " + adicao);
                Console.WriteLine("Raiz cúbica da adição: " + Math.Pow(adicao, 0.33));
            }
            else
            {
                Console.WriteLine("Números digitados: " + num1 + "e" + num2 );
                Console.WriteLine("Valor da adição: " + adicao);
            }
            Console.Read();
        }
    }
}
