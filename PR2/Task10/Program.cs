﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


using static System.Console;
Clear();

WriteLine("Введите трехзначное число");
int num = int.Parse(ReadLine()!);

if (100 <= num && num <= 999)
    {
        num = (num / 10) % 10;
    }
    else 
    {
        WriteLine("Введено не трехзначное число");
    }   