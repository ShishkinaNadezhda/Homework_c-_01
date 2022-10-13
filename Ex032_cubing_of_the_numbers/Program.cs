// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{N} -> ");
PrintCube(N);

static void PrintCube(int N)
    {
        for(int i = 1; i < N; i++)
        {
            Console.Write($"{i * i * i}, ");
        }
            }
Console.Write($"{N * N * N} ");