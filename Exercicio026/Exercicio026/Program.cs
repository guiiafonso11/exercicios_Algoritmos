using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio026
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor qualquer. Obs: Deve ser maior que zero: ");
            double valor = double.Parse(Console.ReadLine());

            if(valor % 2 == 0)
            {
                Console.WriteLine("Valor: " + valor + "\n" + "O número e Par!" );   
            }
            else
            {
                Console.WriteLine("Valor: " + valor + "\n" + "O número é Impar!");
            }
        }
    }
}
