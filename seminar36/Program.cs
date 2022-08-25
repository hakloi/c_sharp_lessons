int[] array = new int[6];

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] res = GetArray(array);
string text = "\nМассив: ";
Console.Write(text);
PrintArray(res);

int[] MultiplicationArray (int[] arr)
{
    int[] newArray = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length-i-1];
        if (arr[i] == arr[arr.Length-i-1])
        {
            break;
        }
    }
    return newArray;
}

int[] newRes = MultiplicationArray(array);
string textNew = "\nНовый массив: ";
Console.Write(textNew);
PrintArray(newRes);