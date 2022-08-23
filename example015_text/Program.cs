string text = "\n Когда же юности мятежной \n"
+ "Пришла Евгению пора, \n"
+ "Пора надежд и грусти нежной, \n"
+ "Monsieur прогнали со двора. \n";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '_');


Console.WriteLine(newText);