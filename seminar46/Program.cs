Console.Clear();

Console.Write("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены неправильные данные.");
    return;
}

int[,] result = FillArray2D(m, n);

PrintArray2D(result);

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m,n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = random.Next(10,1001);
        }
    }
    return array;
}

void PrintArray2D(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Получим массив: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i,j]} ");;
        }
    Console.WriteLine();
    }
}