Console.Clear();

Console.Write("Значение первой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Значение второй стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Значение третьей стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

void TriagleExists (int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b) 
    {
        Console.Write($"Треугольник со значениями: {a}, {b}, {c} - может существовать!");
    }
    else
    {
        Console.Write($"Треугольник со значениями: {a}, {b}, {c} - не может существовать!");
    }
}

TriagleExists(a, b, c);