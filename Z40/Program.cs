int GetUserInput()
{
    Console.WriteLine("введите число:"); 
    return Convert.ToInt32(Console.ReadLine());  
}

int number1 = GetUserInput();
int number2 = GetUserInput();
int number3 = GetUserInput();

bool GetTriangle(int num1,int num2,int num3)
{
    if (num1 < num2 + num3 &&num2 < num1 + num3 &&num3 < num1 + num2)
        return true;
    return false;
}
if(GetTriangle(number1, number2, number3))
    Console.WriteLine("Треугольник с такиме сторонами  может существовать");
else
    Console.WriteLine("Треугольник с такиме сторонами не может существовать");