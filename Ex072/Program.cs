// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа от M до N.
// N = 5 -> 1, 2, 3, 4, 5


Console.Clear();
int num1 = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");

if (num1 < num2)
    {
        Console.WriteLine(PrintNaturals(num1, num2));
    }
    else
    {
        Console.WriteLine($"Вывод невозможен, {num1} больше {num2}");
    }

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
            Console.WriteLine(errorMessage);
    }
}

string PrintNaturals(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + ", " + PrintNaturals(start + 1, end));
}