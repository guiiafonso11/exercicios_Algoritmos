using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio030
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler uma temperatura em graus Celsius e apresentá-la convertida em graus
            Fahrenheit.
            A fórmula de conversão é: F = C * (9.0 / 5.0) + 32.0, sendo F a temperatura em Fahrenheit e
            C a temperatura em Celsius.*/

            Console.Write("Digite a temperatura em graus Celsius: ");
            double C = double.Parse(Console.ReadLine());

            double F = C * ((9.0 / 5.0)) + 32.0;

            Console.WriteLine("Temperatura em Fahrenheit: " + F);
        }
   
    }
}
