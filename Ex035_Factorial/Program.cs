// Напишите программу, которая принимает N,
// и выдает произведение от 1 до N.
// 4 -> 24   1*2*3*4=24
// 5 -> 120

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int Factorial = GetFactorial(N);

Console.WriteLine(Factorial);

static int GetFactorial(int N)
{
    int a = 1;
    int Factorial = 1;
    while (a <= N)
    {
        Factorial = a * Factorial;
        a++;
    }
    return Factorial;
}