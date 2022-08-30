Console.Clear();

int[] array = new int[7];

int[] RandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 21);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] randomArray = RandomArray(array);
PrintArray(randomArray);

int[] TurnOverArray(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

int[] turnOver = TurnOverArray(randomArray);
string text = "\nПеревернутый ";
Console.Write(text);
PrintArray(turnOver);