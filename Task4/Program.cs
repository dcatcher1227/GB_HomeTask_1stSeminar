﻿Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());
int max = 1;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(max);