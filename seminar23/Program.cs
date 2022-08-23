Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum(int num)
{
    int result = 0;
    for (int i = 0; i <= num; i++)
    {
        result += i;
    }
    return result;
}

int Sum = GetSum(number);
Console.WriteLine($"Получими: {Sum}");