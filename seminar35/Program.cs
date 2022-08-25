Console.Clear();
int[] array = new int[123];

int[] RandomArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 200);
    }
    return arr;
}

int[] PrintArray(int[] arr)
{
    string text = "\nПолучили новый массив: ";
    Console.WriteLine(text);
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= 99 & arr[i] >= 10)
        {
            count++;
            Console.Write($"{arr[i]} ");
        }
    }
    return arr;
}

int[] res = RandomArray(array);
PrintArray(res);