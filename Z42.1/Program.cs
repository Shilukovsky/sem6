int GetUserInput()
{
    Console.WriteLine("введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetUserInput();

void ToBin(int n)
{
    if (n == 0)
    {
        return;
    }
    ToBin(n / 2);
    Console.Write(n % 2);
}

ToBin(a);