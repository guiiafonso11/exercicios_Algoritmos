using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio045
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O cardápio de uma lanchonete é o seguinte:
                Código Especificação Preço unitário
                100 Cachorro quente 4,50
                101 Bauru simples 4,50
                102 Bauru c/ovo 5,50
                103 Hambúrguer 6,50
                104 Refrigerante 3,50
            Escrever um algoritmo que leia o código do item pedido, a quantidade e calcule o valor
            a ser pago por aquele lanche.
            Considere que a cada execução somente será calculado um item */

            double cachorro = 4.50;
            double bauruS = 4.50;
            double bauruOVO = 5.50;
            double burguer = 6.50;
            double refri = 3.50;
            double conta = 0;
            int qtd = 0;

            Console.Write("O que deseja pedir?" + "\n" + "100 - Cachorro quente 4,50" + "\n" +
                "101 - Bauru simples - 4,50" + "\n" +
                "102 - Bauru c/ovo - 5,50" + "\n" +
                "103 - Hambúrguer - 6,50" + "\n" +
                "104 - Refrigerante - 3,50" + "\n");
            double pedido = double.Parse(Console.ReadLine());

            switch (pedido)
            {

                case 100:
                    Console.Write("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    conta = cachorro * qtd;
                    Console.WriteLine("Valor: " + conta);
                    break;
                case 101:
                    Console.Write("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    conta = bauruS * qtd;
                    Console.WriteLine("Valor: " + conta);
                    break;
                case 102:
                    Console.Write("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    conta = bauruOVO * qtd;
                    Console.WriteLine("Valor: " + conta);
                    break;
                case 103:
                    Console.Write("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    conta = burguer * qtd;
                    Console.WriteLine("Valor: " + conta);
                    break;
                case 104:
                    Console.Write("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    conta = refri * qtd;
                    Console.WriteLine("Valor: " + conta);
                    break;
                default:
                    Console.Write("Digite um valor válido!");

                    break;
            }














        }
    }
}
