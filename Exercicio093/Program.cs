Console.Write("Digite a quantidade de voltas: ");
int qtVoltas = int.Parse(Console.ReadLine());

int[] arr = new int [qtVoltas];

for(int = 0; i < arr.Length; i++) {
    Console.Write("Digite o tempo de cada volta em segundos: ");
    arr[i] = int.Parse(Console.ReadLine());
}

int MelhorVolta = arr[0];
int volta = 0;

for(int i = 1; i< arr.Length; i++){
    if(arr[i] < melhorVolta){
        volta = i;
    }
    }
     Console.WriteLine("Melhor Volta: " + melhorVolta);
     Console.WriteLine("Volta n°: " + volta );

     int soma = 0;
     double mediatempo = 0;

     for(int i = 0; i < arr.Length; i++){
         soma+=arr[i];
     }
     double media = soma / arr.Length;
     Console.WriteLine("Média de tempo: " + media);