// Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N.
// N = 5 -> 1, 2, 3, 4, 5

Console.WriteLine($"Введите целое число N: ");

int n = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine(PrintNaturals(1, n));

static string PrintNaturals(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }

return (start + ", " + PrintNaturals(start + 1, end));
}