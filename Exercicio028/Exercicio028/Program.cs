
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio028
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());


            if (num1 > 0)
            {
                Console.WriteLine(num1);
                Console.WriteLine("O primeiro número é Positivo");
            } else if (num1 < 0)
            {
                Console.WriteLine(num1);
                Console.WriteLine("O primeiro número é Negativo");
            }
            else
            {
                Console.WriteLine(num1);
                Console.WriteLine("O primeiro número é neutro");
            }
            if (num2 > 0)
            {
                Console.WriteLine(num2);
                Console.WriteLine("O segundo número é Positivo");
            }
            else if (num2 < 0)
            {
                Console.WriteLine(num2);
                Console.WriteLine("O segundo número é Negativo");
            }
            else
            {
                Console.WriteLine(num2);
                Console.WriteLine("O segundo número é neutro");
            }
            if (num3 > 0)
            {
                Console.WriteLine(num3);
                Console.WriteLine("O terceiro número é Positivo");
            }
            else if (num3 < 0)
            {
                Console.WriteLine(num3);
                Console.WriteLine("O terceiro número é Negativo");
            }
            else
            {
                Console.WriteLine(num3);
                Console.WriteLine("O terceiro número é neutro");
            }
            Console.WriteLine("O maior número é: ");
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("O número 1 é o maior");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine("O número 2 é o maior");
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine("O número 3 é o maior"); } } } }


