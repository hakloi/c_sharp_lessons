Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string ConvertBinary(int N)
{
    string num = String.Empty;
    while (N > 0)
    {
        num = N % 2 + num;
        N = N / 2;
    }
    return num;
}

string result = ConvertBinary(number);
Console.WriteLine(result);