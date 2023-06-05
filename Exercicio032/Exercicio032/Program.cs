using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio032
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receber o salário de um funcionário, exibir o valor deste salário, calcular e mostrar
             novo salário, sabendo que ele recebeu um aumento de 25 %. */

            Console.Write("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());
            double porcentagem = 25.0/100.0;
            double valorFinal = salario + (porcentagem * salario);

       

            Console.WriteLine("Novo salário: " + valorFinal);
        }
    }
}
