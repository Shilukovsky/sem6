Console.Write($"Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] number = new int[m];

void GetNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        number[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int GetCountUpO(int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
            count += 1;
    }
    return count;
}

GetNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {GetCountUpO(number)} ");