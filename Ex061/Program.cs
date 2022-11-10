// написать программу, которая принимает на вход три числа и проверяет
// может ли существовать треугольник со сторонами такой длины.
// Каждая сторона треугольника меньше суммы двух других сторон.

int a = GetNumber("Введите длину первой стороны треугольника: ", "Ошибка ввода!");
int b = GetNumber("Введите длину второй стороны треугольника: ", "Ошибка ввода!");
int c = GetNumber("Введите длину третьей стороны треугольника: ", "Ошибка ввода!");

Triangle(a, b, c);


static int GetNumber(string message, string errormessage)
{
while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int result);
        if (isCorrect)
        {
            return result;
        }
        else
        {
            Console.WriteLine(errormessage);
        }
    }
}

void Triangle(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        Console.Write("Такой треугольник может существовать");
    }
    else
    {
        Console.Write("Такой треугольник не может существовать");
    }
}