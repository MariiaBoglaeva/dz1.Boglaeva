﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    Console.WriteLine($"Максимальное число {numberOne}, минимальное число {numberTwo}.");
}
else if (numberOne < numberTwo)
{
    Console.WriteLine($"Максимальное число {numberTwo}, минимальное число {numberOne}.");
}
else Console.WriteLine("Числа равны!");