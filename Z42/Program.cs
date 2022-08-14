int GetUserInput()
{
    Console.WriteLine("введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetUserInput();
string Result(int num)
{
    string res = "";
    while (num > 0)
    {
        res += num % 2;
        num /= 2;
    }   
    return res;

}

void PrintString(string result)
{
    for (int i = result.Length - 1; i >= 0; i--)
    {
        Console.Write(result[i]);
    }
}

string res = Result(number);
PrintString(res);