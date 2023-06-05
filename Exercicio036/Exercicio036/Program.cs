using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio036
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor do Produto: ");
            double produto = double.Parse(Console.ReadLine());
            double desconto = 9.0 / 100.0;

            double novoValor = produto - (desconto * produto);

            Console.WriteLine("Novo Valor: " + novoValor);
        }
    }
}
