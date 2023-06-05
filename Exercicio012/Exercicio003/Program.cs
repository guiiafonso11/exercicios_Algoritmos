using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            Console.WriteLine("O número digitado foi: " + numero + "\n" + "Sua raiz cúbica é: " + Math.Pow(numero, 1.0 / 3.0) + "\n" + "Sua raiz quadrada é: " + Math.Sqrt(numero));
        }
    }
}
