// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using static System.Console;
Clear();

Write("Введите число M и число N через пробел: ");

string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);


int sum = 0;
int Fatorial (int a)
{
    if (a==1) return 1;
    else  return a;
}
for (int i = int.Parse(parameters[0]); i <= int.Parse(parameters[1]); i++)
{
    sum += Fatorial(i);
}
WriteLine(sum);