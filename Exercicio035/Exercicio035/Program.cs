using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio035
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double D = 6 / 2;
            double d =  8 / 2;

           double D2 = Math.Pow(D, 2);
           double d2 = Math.Pow(d, 2);

           double conta = D2 + d2;

            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Resultado: " + Math.Sqrt(conta));

           // if((D <=0) && (d <= 0))
           // {
             //   Console.WriteLine("Valores inválidos!");
           // }
        }
    }
}
