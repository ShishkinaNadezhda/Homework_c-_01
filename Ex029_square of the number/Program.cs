// Напишите программу, которая принимает на вход число N
// и выдает таблицу квадратов числа от 1 до N
// 5 -> 1, 5, 25
// 2 -> 1, 4

Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{N} -> ");
PrintSquares(N);

/////////////////////////////////////
static void PrintSquares(int N)
    {
        for(int i = 1; i < N; i++)
        {
            Console.Write($"{i * i}, ");
        }
            }
Console.Write($"{N * N} ");