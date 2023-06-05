/*Entrar com o nome e duas notas de um aluno.
 As notas vão de zero a dez. O algoritmo deve imprimir o nome do aluno, suas
notas e sua média.
 Se a nota for maior que 7 – imprimir “Aprovado”.
 Se a nota for menor que 5 – imprimir “Retido”.
 Caso contrário - imprimir “Recuperação”.
 Se as notas não estiverem no intervalo estabelecido o algoritmo deve emitir
uma mensagem de erro. */

Console.Write("Digite o nome do aluno: ");
string nome = string.Parse(Console.ReadLine());

Console.Write("Digite a primeira nota dele (0 a 10): ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota dele (0 a 10): ");
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;

if(media >= 7){
    Console.WriteLine("Sua média foi: " + media  + "Você foi Aprovado!");
}
else if (media <= 5){
    Console.WriteLine("Sua média foi: " + media + "Você foi Retido!");
}
else if ((media >= 7) || (media <= 5)){
    Console.WriteLine("Em Recuperação!");
}
else{
    Console.WriteLine("Digite notas válidas!");
}