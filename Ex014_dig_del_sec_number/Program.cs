// Напишите программу, которая принимает на вход трехзначное число и на выходк
// показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);

int a2_1 = num % 100;
int a2 = a2_1 / 10;
Console.WriteLine($"Вторая цифра случайного числа: {a2}");