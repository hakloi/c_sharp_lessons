Console.Clear();

Console.Write("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Данные введены неправильно.");
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
            array[i,j] = random.Next(1,22);
        }
    }
    return array;
}

void PrintArray2D(int[,] arr)
{
    Console.WriteLine();
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
Console.Write("Новый массив: ");
PrintArray2D(result);

int[,] SquareOfEvenIndexes(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 0 && j % 2 == 0
            && i != 0 && j != 0)
            {
                arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
            }
        }
    }
    return arr;
}

int[,] res = SquareOfEvenIndexes(result);
Console.Write("Измененный массив:");
PrintArray2D(res);
