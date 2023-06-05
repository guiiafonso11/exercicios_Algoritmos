double soma = 0;
int contador = 0;

while(contador<1000){
    contador +=1;
    if(contador%3==0){
        soma+=contador;
    }else if (contador%5==0){
        soma+=contador;
    }
    soma+=contador*2;
    Console.WriteLine(soma);
}
