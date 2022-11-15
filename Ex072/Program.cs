// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа от M до N.
// N = 5 -> 1, 2, 3, 4, 5

Console.WriteLine($"Введите целое число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"Введите целое число M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine(PrintNaturals(m, n));

if (m < n)
{
    Console.WriteLine($"{PrintNaturals(m, n)}");
}
else
{
    Console.WriteLine("Вывод невозможен!");
}


string PrintNaturals(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }

return (start + ", " + PrintNaturals(start + 1, end));
}