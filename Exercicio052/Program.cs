int num = 0;
int positivo = num;
int negativo = num;

if(num>0 && num<0){
    while(num >= 0){

    Console.Write("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if(num > positivo){
        positivo = num;
    }
    if(num < negativo && num>= 0 ){ 
        negativo = num;
    }

}
Console.WriteLine("Quantidade de números positivos: " + positivo);