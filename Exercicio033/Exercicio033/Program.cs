using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio033
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura do degrau da escada: ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura que deseja alcançar subindo a escada: ");
            double hDesejada = double.Parse(Console.ReadLine());

            double objetivo = h - hDesejada;

            Console.WriteLine("Altura que se deve alcançar: " + objetivo);
        }
    }
}
