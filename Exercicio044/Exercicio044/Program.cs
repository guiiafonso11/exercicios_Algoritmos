using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio044
{
    class Program
    {
        static void Main(string[] args)
        { 
            double p1 = 1.50;
            double p2 = 2.60;
            double p3 = 3.75;



            Console.WriteLine("O que você deseja comprar? " + "\n" + "1 - Picolé Tipo 1" + "\n" + 
                                                                 "2 - Picolé Tipo 2" + "\n" + 
                                                                  "3 - Picolé Tipo 3");
           
            Console.WriteLine("Quantos picolés do tipo 1 você deseja comprar? ");
            double qtd1 = double.Parse(Console.ReadLine());
     
            double x1 = p1 * qtd1;

            Console.WriteLine("Quantos picolés do tipo 2 você deseja comprar? ");
            double qtd2 = double.Parse(Console.ReadLine());

            double x2 = p2 * qtd2;

            Console.WriteLine("Quantos picolés do tipo 3 você deseja comprar? ");
            double qtd3 = double.Parse(Console.ReadLine());

            double x3 = p3 * qtd3;

            double valor = x1 + x2 + x3;

            Console.WriteLine("Valor da sua compra: " + valor );
            Console.ReadLine();
            }
         
            }

      




        }
    

