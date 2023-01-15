/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3
*/

Console.Write("Введите 1-е число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine ($"a = {number1}; b = {number2} -> max = {number1}");
    else
    Console.WriteLine ($"a = {number1}; b = {number2} -> max = {number2}");


