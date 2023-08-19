// Algoritmo de ordenação por seleção

int[] array = new int[] { 14, 26, 2, 4, 28, 0, 152, 20 };
Console.WriteLine($"Array desordenado: {string.Join(", ", array)}");
OrdenarArray(ref array);

static void OrdenarArray (ref int[] array)
{
    int temp;
for(int i=0; i < array.Length ; i++)
{
    for(int j = 0; j < array.Length-1; j++)
    {
        if(array[j] > array[j+1])
        {
            temp = array[j + 1];
            array[j + 1] = array[j];
            array[j] = temp;
        }
    }
    
}

}

Console.WriteLine($"Array ordenado: {string.Join(", ", array)}");






