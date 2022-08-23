Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetFactorial(int num)
{
    int result = 1;
    if (num == 1)
    {
        return 1;
    }

    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}

int res = GetFactorial(number);
Console.WriteLine($"Из числа {number}, получили факториал этого числа, равный =  {res}.");