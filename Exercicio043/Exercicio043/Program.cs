using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio043
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua Altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu Peso: ");
            double peso = double.Parse(Console.ReadLine());

            double IMC = peso / (Math.Pow(altura, 2)) * 10000;

            if (IMC < 17)
            {
                Console.WriteLine("Muito abaixo do peso: " + IMC);
            }
            else if ((IMC == 17 && IMC <= 18.49))
            {
                Console.WriteLine("Abaixo do peso: " + IMC);
            }
            else if ((IMC == 18.5 && IMC <= 24.99)){
                Console.WriteLine("Peso normal: " + IMC);
            }
            else if ((IMC == 25 && IMC <= 29.99))
            {
                Console.WriteLine("Acima do Peso: " + IMC);
            }
            else if ((IMC == 30 && IMC <= 34.99))
            {
                Console.WriteLine("Obesidade I: " + IMC);
            }
            else if ((IMC == 35 && IMC <= 39.99))
            {
                Console.WriteLine("Obesidade II: " + IMC);
            }
            else if (IMC >= 40)
            {
                Console.WriteLine("Obesidade III: " + IMC);
            }

        }
        }
    }

