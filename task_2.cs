﻿/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3
*/

Console.Write("Введите 1-е число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine ($"1-е число '" + number1 + "' больше");
    else
    Console.WriteLine ($"2-е число '" + number2 + "' больше");


