/*
Задача 22:
Напишите программу, которая принимает на вход число (N)
и выдвет таблицу квадратов чисел от 1 до N.
*/

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < number | i == number)
{
    Console.WriteLine(Math.Pow(i, 2));
    i++;
}


