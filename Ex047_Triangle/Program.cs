// Написать программу, которая принимает на вход 3 числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника - каждая сторона треугольника
// меньше суммы длин двух остальных сторон.

int A = UserInput("Введите первое число: ", "Ошибка!");
int B = UserInput("Введите второе число: ", "Ошибка!");
int C = UserInput("Введите третье число: ", "Ошибка!");

Console.WriteLine($"Стороны треугольника: {A}, {B}, {C}");

TriangleCheck(A, B, C);

static int UserInput(string message, string errormessage)
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

static void TriangleCheck(int A, int B, int C)
{
    if (A < (B + C) && B < (A + C) && C <(A + B))
    {
        Console.Write("Это треугольник");
    }
    else
    {
        Console.WriteLine("Это не треугольник");
    }
}