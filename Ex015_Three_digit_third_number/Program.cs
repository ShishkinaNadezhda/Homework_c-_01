﻿// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

int num = new Random().Next(9, 10000);
Console.WriteLine($"Случайное число  {num}");

if(num < 100)
{
    Console.WriteLine($"У числа {num} нет третьей цифры");
}

if(num > 99 & num < 1000)
{
    int a2_1 = num % 100;
    int a2 = a2_1 / 10;
    int a3 = a2_1 % 10;
    Console.WriteLine($"Третья цифра случайного числа  {a3}");
}

if(num > 999)
{
    int a3_1 = num % 100;
    int a3_2 = a3_1 / 10;
    Console.WriteLine($"Третья цифра случайного числа  {a3_2}");
}