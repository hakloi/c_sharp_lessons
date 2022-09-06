Console.Clear();

Console.Write("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

Console.Write("Введите минимальное число: ");
bool minValue = int.TryParse(Console.ReadLine(), out int minNum);

Console.Write("Введите максимальное число: ");
bool maxValue = int.TryParse(Console.ReadLine(), out int maxNum);

if (isNumberM == false || isNumberN == false
    || minValue == false || maxValue == false)
{
    Console.WriteLine("Введены неправильные данные.");
    Console.Write("Введите число!");
    return;
}

int[,] FillArray2D(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(minValue, maxValue);
        }
    }
    return arr;
}

int[,] result = FillArray2D(m, n, minNum, maxNum);

void PrintArray2D(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Массив: ");
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray2D(result);

int[] CounterElements(int[,] array, int minNum, int maxNum)
{
    int[] Count = new int[maxNum - minNum];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Count[array[i,j]] += 1;
        }
    }
    return Count;
}

int[] counter = CounterElements(result, minNum, maxNum);

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine();
PrintArray(counter);
