/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7 44 5 78 -> 78 22 3 9 -> 22
*/

Console.Write("Введите 1-е число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2 && number1 > number3)
    Console.WriteLine ($"{number1}, {number2}, {number3} -> {number1}");
    else if (number2 > number3)
    Console.WriteLine ($"{number1}, {number2}, {number3} -> {number2}");
    else
    Console.WriteLine ($"{number1}, {number2}, {number3} -> {number3}");

/*
if (number1 > number2 && number1 > number3)
    Console.WriteLine ("1-е число '" + number1 + "' больше");
    else if (number2 > number3)
    Console.WriteLine ("2-е число '" + number2 + "' больше");
    else
    Console.WriteLine ("3-е число '" + number3 + "' больше");
*/
