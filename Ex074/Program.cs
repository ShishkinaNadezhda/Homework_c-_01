// Напишите программу, которая на вход принимать два числа - A и B,
// и возводит число A в целую степень B с помощью рекурсии.

Console.Write($"Введите целое число A: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write($"Введите целое число B: ");
int b = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{PowerNumber(a, b)}");

int PowerNumber (int a, int b)
{
    if (b == 0) return 1;
    return a * PowerNumber(a, b-1);
}
