using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = (Console.ReadLine());

            Console.Write("Digite a primeira nota dele (0 a 10): ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota dele (0 a 10): ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = ((nota1 + nota2) / 2);

            if (media > 7.0)
            {
                Console.WriteLine("Nome:" + nome + "\n" + "Sua média foi: " + media + " Você foi Aprovado!");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Nome:" + nome + "\n" + "Sua média foi: " + media + " Você foi Retido!");
            }
            else if ((media <=7) && (media >= 5)){
                Console.WriteLine("Nome:" + nome + "\n" +  "Sua média foi: " + media + " Você está de Recuperação!");
            }
        }
    }
}
