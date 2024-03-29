﻿//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""


void PrintNumbers(int min, int max)
{
    if( min < max ) 
    {
        Console.Write($"{min},");
        PrintNumbers(++min, max);
    }
    else if (min > max)
    {
        Console.Write($"{min},");
        PrintNumbers(--min, max);
    }
    else Console.Write($"{min}");
}

Console.WriteLine("Введите число начала :");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число конца :");
int max = int.Parse(Console.ReadLine());

PrintNumbers(min, max);