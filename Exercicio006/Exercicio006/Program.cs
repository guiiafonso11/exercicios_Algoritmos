using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio006
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 500;
            int num2 = 500;

            Console.WriteLine("Os números digitados foram: " + num1 +  " e " + num2 +
                              "\n" + "A soma dos números: " + num1 + " e " + num2 + " é " + "\t" + (num1 + num2) + "\n" +
                              "A subtração dos números: " + num1 + " e " + num2 + " é " + "\t" + (num1-num2) + "\n" + 
                              "A multiplicação dos números: " + num1 + " e " + num2 + "  " + "\t" + (num1*num2) + "\n" +
                              "A divisão dos números: " + num1 + " e " + num2 + " é " + "\t" + (num1/num2) + "\n" + 
                              "A média dos números: " + num1 + " e " + num2 + " é " + "\t" + (num1 + num2 / 2)
                              );
        }
    }
}
