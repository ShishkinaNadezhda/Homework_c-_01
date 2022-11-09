// Задайте двумерный массив размером m*n,
// заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, colums, -100, 100);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} " );
        }
        Console.WriteLine();
    }
}

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //Convert.ToDouble(rnd.Next(-100, 100)/10.0)
            //new Random().NextDouble() * 10
            result[i, j] = Convert.ToDouble(rnd.Next(minValue, maxValue + 1)/10.0);
           // Console.Write("{0,6:F2}", result[i, j]);
        }
    }
    return result;
}