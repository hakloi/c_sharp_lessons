﻿Console.Clear();

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

Console.WriteLine("Числа Фибоначчи: ");
for (int i = 1; i < 40; i++)
{
    
    Console.WriteLine($"f({i}) = {Fibonacci(i)} ");
}