﻿Console.Clear();
Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Наибольшее число это {number1}");
}
else
{
    Console.WriteLine($"Наибольшее число это {number2}");
}