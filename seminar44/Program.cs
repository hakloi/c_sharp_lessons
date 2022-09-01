Console.Clear();
int[,] array2d = new int[5, 5];
Random random = new Random();

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = random.Next(10, 100);
    }
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Print2dArray(array2d);

int[,] CopiedArray(int[,] arr)
{
    int[,] array = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = arr[i, j];
        }
    }
    return array;
}

string text = "\nСкопированный массив: \n";
Console.Write(text);
int[,] result = CopiedArray(array2d);
Print2dArray(result);