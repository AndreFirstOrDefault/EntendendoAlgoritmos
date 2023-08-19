// Algoritmo de pesquisa binária

int[] lista = Enumerable.Range(1, 1000).ToArray();

int baixo = 1;
int alto = 10;
int meio = 0;
int chute = 0;  
int item = 3;
int tentativas = 0;
Random random = new Random();
item = random.Next(1, 1000);

Console.WriteLine("Adivinhe um número de 1 a 1000");
Console.Write("Digite o número: ");

while(chute != item)
{
    tentativas++;
    chute = int.Parse(Console.ReadLine());

    if(chute < item)
    {
        alto = item;
        meio = (baixo + alto) / 2;
        Console.Write($"Tente um valor mais alto que {chute}: ");
        continue;
    } 
    if(chute > item)
    {
        alto = item;
        meio = (baixo + alto) / 2;
        Console.Write($"Tente um valor mais baixo que {chute}: ");
        continue;
    } 
}

Console.Write($"Você acertou o valor depois de {tentativas} tentativas, o número é {item}");


