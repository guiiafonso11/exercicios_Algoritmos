double soma = 0;
int contador = 1;

while(contador<=100){
    contador +=1;
    if((contador%5==0) && (contador%7==0)){
        soma+=contador*2;
    }
    Console.WriteLine(soma);
}