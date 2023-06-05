int[] numero = new int [10];

for(int i = 0; i < numero.Length; i++){

    Console.Write("Digite um número maior que zero: ");
    int n = int.Parse(Console.ReadLine());

    if(n > 0 ){
        numero[i] = n;
    }else{

        do{
            Console.WriteLine("Você digitou um valor errado!!");
            Console.Write("Digite um número maior que zero: ");
            n = int.Parse(Console.ReadLine());
            numero[i] = n;
        }while (n<= 0);
    }
}

Console.WriteLine("Numeros pares: ");
for(int i = 0; i< numero.Length; i++){
    if(numero[i] %2 ==0){
        Console.WriteLine(numero[i]);
    }
}
Console.WriteLine("Numeros impares: ");
    for(int i = 0; i <numero.Length; i++){
        if(numero[i] %2 != 0){
            Console.WriteLine(numero[i]);
    }
}

string par = "";
string impar = "";

for(int i = 0; i <numero.Length; i++){
         if(numero[i] %2 == 0){
             par += numero[i] + "";
         }else{
             impar += numero [i] + "";
         }
}
Console.WriteLine("Numeros pares: " + par);
Console.WriteLine("Numeros impares: " + impar);