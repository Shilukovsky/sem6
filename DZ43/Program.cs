int GetUserInput()
{
    Console.WriteLine("введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int k1 = GetUserInput();
int k2 = GetUserInput();
int b1 = GetUserInput();
int b2 = GetUserInput();

double x = -(b1 - b2) / (k1 - k2);
double y = k2 * x + b2;

x = Math.Round(x, 1);
y = Math.Round(y, 1);

Console.WriteLine($"Пересечение в точке: ({x}; {y})");
