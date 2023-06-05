using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio034
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da Diagonal Maior (D): ");
            int D = int.Parse(Console.ReadLine());

            Console.Write("Digite o tamanho da Diagonal menor (d): ");
            int d = int.Parse(Console.ReadLine());

            double area = (d * D) / 2;

            if ((D <= 0) && (d <= 0))
            {
                Console.WriteLine("Valores Inválidos!: " + D) ;

            }
            else
            {
                Console.WriteLine("Área do Losango: " + area);
            }
            }
            }
        }
  

