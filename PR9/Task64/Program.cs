﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int j = 8;
double Fatorial (int n)
{
    if (n==1) return 1;
    else  return n;
}
for (int i = j; i != 0; i--)
{
    Console.WriteLine(Fatorial(i));
}