using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Que tipo de operação você deseja efetuar?: " + "\n" + "1 - Soma" + "\n" + 
                                                                                 "2 - Subtração" + "\n" +
                                                                                 "3 - Divisão" + "\n" +
                                                                                 "4 - Multiplicação" + "\n");
            int conta = int.Parse(Console.ReadLine());

            switch (conta) {

                case 1:
                    Console.Write("Digite um número: ");
                    int som1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite outro número: ");
                    int som2 = int.Parse(Console.ReadLine());

                    int soma = som1 + som2;

                    Console.WriteLine("Soma: " + soma);

                    break;


                case 2:
                    Console.Write("Digite o número que irá subtrair: ");
                    int sub1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o subtraendo: ");
                    int sub2 = int.Parse(Console.ReadLine());

                    int subtracao = sub1 - sub2;

                    Console.WriteLine("Subtração: " + subtracao);

                    break;

                case 3:
                    Console.Write("Digite o número que vai ser dividido: ");
                    double div1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o divisor: ");
                    double div2 = int.Parse(Console.ReadLine());

                    double divisao = div1 / div2;

                    Console.WriteLine("Divisão: " + divisao);

                    break;


                case 4:
                    Console.Write("Digite um número para multiplicar: ");
                    int mult1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o outro número: ");
                    int mult2 = int.Parse(Console.ReadLine());

                    int multiplicacao = mult1 * mult2;

                    Console.WriteLine("Multiplicação: " + multiplicacao);

                    break;

            }


        }
    }
}
