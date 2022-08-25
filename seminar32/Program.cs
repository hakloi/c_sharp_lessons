int[] array = new int[4]{-4,-8,8,2};

int[] ChangeSymbols(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i]*(-1);
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

int[] result = ChangeSymbols(array);
PrintArray(result);