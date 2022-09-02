Console.Clear();

Console.Write("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены неправильные данные.");
    Console.Write("Введите число!");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = random.Next(1,21);
        }
    }
    return array;
}

void PrintArray2D(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] result = FillArray2D(m, n);
Console.WriteLine();
Console.Write("Новый массив: ");
Console.WriteLine();
PrintArray2D(result);

int SumOfEvenIndexes(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Сумма чисел по диагонали: ");
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                Console.Write($"{arr[i,j]} + ");
                sum = sum + arr[i,j];
            }
        }
    }
    Console.Write($"= {sum}!");
    return sum;
}

int sumResult = SumOfEvenIndexes(result);
Console.WriteLine();