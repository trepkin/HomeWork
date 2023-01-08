// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

using static System.Console;
Clear();

WriteLine("Введите число N");
int N = int.Parse(ReadLine()!);
int i = 1;
int stepen = 3;

while ( i <= N )
    {
        Write($"{Math.Pow(i, stepen)}, ");
        i++;
    }