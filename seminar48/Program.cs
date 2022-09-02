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

    for (int i = 0; i < m; i++)
    {
        array[i, 0] = i+1;
    }

    for (int j = 1; j < n; j++)
    {
        array[0, j] = j+1;
    }

    for (int ix = 1; ix < m; ix++)
    {
        for (int jy = 1; jy < n; jy++)
        {
            array[ix,jy] = array[ix,0] + array[0, jy];
        }
    }

    return array;
}

void PrintArray2D(int[,] arr)
{
    Console.Write("Новый массив: ");
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
PrintArray2D(result);