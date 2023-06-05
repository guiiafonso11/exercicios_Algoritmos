using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio037
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            double num = double.Parse(Console.ReadLine());
            double num2 = Math.Pow(num, 2);

            if(num2 > 10.00)
            {
                Console.WriteLine("Ele é maior que 10: " + num2 + "\n" + "E sua raiz cúbica é: " + Math.Pow(num2, 0.33));
            }
            else if (num2 == 10.00)
            {
                Console.WriteLine("Ele é igual a 10: " + num2);
            }
            else
            {
                Console.WriteLine("Ele é menor que 10: " + num2);
            }
        }
    }
}
