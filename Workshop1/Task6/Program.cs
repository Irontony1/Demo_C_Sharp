﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Здравствуйте, я помогу определить является ли число четным");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int div = number % 2;
if (div == 0)
{
    Console.WriteLine( "Число " + number + " является четным" );
}
else
{
    Console.WriteLine( "Число " + number + " не является четным" );
}