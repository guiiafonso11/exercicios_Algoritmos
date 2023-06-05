using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            double qnum1 = Math.Pow(num1, 2);
            double qnum2 = Math.Pow(num2, 2);
            double qnum3 = Math.Pow(num3, 2);

            double soma = qnum1 + qnum2 + qnum3;

            Console.WriteLine("Quadrado dos números: " + "\n" + "número 1: " + qnum1 +"\n" + "número 2: " + qnum2 +"\n" + "número 3: " + qnum3);
            Console.WriteLine("Soma do quadrado dos números: " + soma);
            if (soma % 2 ==0)
            {
                Console.WriteLine("A soma do quadrado dos números é par!");
            }
            else
            {
                Console.WriteLine("A soma do quadrado dos números é impar!");
            }
        }
    }
}
