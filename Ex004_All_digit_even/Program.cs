﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

Console.Write($"{userNumber} -> ");
int i = 0;

while(i < userNumber)
{
    i += 2;
    Console.Write($" {i}, ");
}