Console.Write("Digite um número");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite outro número");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2){
    int aux = num1;
    num1 = num2;
    num2 = aux;
}

int soma = 0;

while(num1 > 0){
    if(num1 % 7 == 0){
        soma-= num1*2;
    }
    Console.WriteLine(soma);
}