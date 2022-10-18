// Задача 25. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в степень B.
// 3, 5 -> 243
//  2, 4 -> 16

Console.Write("Введите число A ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");

int Pow (int num, int rank)
{
    if(rank == 0) return 1;
    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *=num;
    }
    return result;
}
