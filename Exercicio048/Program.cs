Console.Write("Digite um número maior que zero: ");
int num = int.Parse(Console.ReadLine());

while(num > 0){
    Console.Write(num + "|");
    num--;
}
