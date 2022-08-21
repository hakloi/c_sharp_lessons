/*
Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве.

А(3,6); В(2,1) -> 5,09
*/

Console.Clear();
Console.Write("Введите координату x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
double differenceX = x1;
double differenceY = y1;

if (x1 > x2)
    {
        differenceX = x1 - x2;
    }
    else if (x1 == x2)
    {
        differenceX = x1;
    }
    else 
    {
        differenceX = x2 - x1;
    }

    if (y1 > y2)
    {
        differenceY = y1 - y2;
    }
    else if (y1 == y2)
    {
        differenceY = y1;
    }
    else 
    {
        differenceY = y2 - y1;
    }

differenceX = Math.Pow(differenceX, 2);
differenceY = Math.Pow(differenceY, 2);
double result = Math.Sqrt(differenceX + differenceY);

Console.WriteLine($"Расстояние между точками = {result}.");