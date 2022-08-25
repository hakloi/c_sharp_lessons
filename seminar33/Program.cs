int [] array = new int[8];

int[] GetArray(int [] arr)
{
    for (int i = 0; i < arr.Length;  i++)
    {
        Console.Write("Введите число для добавления в массив: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ThereNotFour(int[] arr)
{
    int num = 4;
    if (arr.Contains(num))
    {
        string textFirst = "\nУДИВИТЕЛЬНО! В массиве присутствует 4!";
        Console.WriteLine(textFirst);
    }
    else
    {
        string text = "\nКошмар...В массиве нет 4!";
        Console.WriteLine(text);
    }
}

int[] result = GetArray(array);
PrintArray(result);
ThereNotFour(result);