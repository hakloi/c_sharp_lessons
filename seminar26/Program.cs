Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int HowManyNum(int num)
{
    string str = num.ToString();
    int result = str.Length;
    
    return result;
}

int res = HowManyNum(number);
Console.WriteLine(res);