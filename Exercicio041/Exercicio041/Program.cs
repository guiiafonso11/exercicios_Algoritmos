using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio041
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número qualquer: ");
            double num = double.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("Número Digitado: " + num + "\n" + "O número é positivo, sua raiz quadrada: " + Math.Sqrt(num));
            }
            else
            {
                Console.WriteLine("Número Digitado: " + num + "\n" + "O número é negativo, ele ao quadrado é: " + Math.Pow(num, 2)); 
            }
        }
    }
}
