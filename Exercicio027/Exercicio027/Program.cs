using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio027
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se o valor do número elevado à quarta for par e múltiplo de cinco o algoritmo
           deverá imprimir a seguinte mensagem:

                    o “O número digitado foi __.”
                    o “Seu valor elevado ao quadrado é __.”
                    o “Seu valor elevado ao cubo é __.”
                    o “Seu valor elevado a sétima é __.”

                    Se o valor for ímpar o algoritmo deverá imprimir a seguinte mensagem:
                    o “O número digitado foi __.”
                    o “Sua raiz quadrada é __.”
                    o “Sua raiz cúbica é __.”
                    o “Sua raiz a sétima é __.”
                    Observação: Se o usuário digitar um valor inválido o algoritmo deverá emitir uma
                    mensagem de erro.*/

            Console.Write("Digite um Número. Obs - Que seja positivo: ");
            double valor = Double.Parse(Console.ReadLine());
            double quarta = Math.Pow(valor, 4);


            if (valor % 2 == 0){
                if ((quarta % 2 == 0) && (quarta % 5 == 0)){
                    Console.WriteLine("O número digitado foi: " + valor +
                        "\n" + "Seu valor elevado ao quadrado é: " + Math.Pow(valor, 2) +
                        "\n" + "Elevado ao Cubo: " + Math.Pow(valor, 3) + "\n" + "Elevado a sétima: "
                        + Math.Pow(valor, 7));
                }
                
            }else{
                Console.WriteLine("O número digitado foi: " + valor +
                     "\n" + "Sua raiz quadrada: " + Math.Sqrt(valor) +
                     "\n" + "Raiz cúbica: " + Math.Pow(valor,  0.33) + "\n" + "Raiz Sétima: "
                     + Math.Pow(valor, 0.14));
            }
            Console.ReadLine();
        }
    }
}
