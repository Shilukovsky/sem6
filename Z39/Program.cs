int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void GetReturnArray(int[] array)
{
    int size = array.Length;
    int ind1 = 0;
    int ind2 = size - 1;

    while (ind1< ind2)
    {
        int temp = array[ind1];
        array[ind1] = array[ind2];
        array[ind2] = temp;

        ind1++;
        ind2--;
    }


}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInt(8, 1, 10);
PrintArray(array);
GetReturnArray(array);
Console.Write(" -> ");
PrintArray(array);
