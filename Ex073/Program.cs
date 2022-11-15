// Напишите программу, которая на вход будет принимать число
// и выдавать сумму его цифр.

Console.Write($"Введите целое число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{SumDigits(n)}");

int SumDigits (int number)
{
    if (number == 0)
        return 0;
    return SumDigits(number/10) + number%10;
}
