int GetUserInput()
{
    Console.WriteLine("введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetUserInput();

void GetFibonachi(int num)
{
    int f0 = 0;
    int f1 = 1;
    int fn = 0;

    Console.Write($"{f0} {f1} ");
    for (int i = 0; i < num - 2; i++)
    {
        fn = f0 + f1;
        Console.Write($"{fn} ");
        f0 = f1;
        f1 = fn;
    }
}

GetFibonachi(number);