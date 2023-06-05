using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio046
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
   
            double mediaA = (nota1 + nota2 + nota3) / 3;
            double mediaP = (nota1 * 3 + nota2 * 3 + nota3 * 4) / (3 + 3 + 4) ;

            Console.Write("Escolha uma opção para tirar a média: " + "\n" + "1 - Aritmédica" + 
                "\n" + "2 - Ponderada" + "\n");
            int mediaF = int.Parse(Console.ReadLine());



            switch (mediaF)
            {
                case 1:
                    Console.WriteLine("Média Final: " + mediaA);
                    break;
                case 2:
                    Console.WriteLine("Média Final: " + mediaP);
                    break;
            }
            Console.ReadLine();
        }
    }
}
