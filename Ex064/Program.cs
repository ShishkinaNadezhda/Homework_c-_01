// Задайте массив. Напишите программу, которая меняет местами
// первую и последнюю строку массива.

static int[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    int[,] randomArray = new int [rows, columns];
    for (int rowsIndex = 0; rowsIndex < rows; rowsIndex++)
    {
        for (int columnsIndex = 0; columnsIndex < columns; columnsIndex++)
        {
            randomArray[rowsIndex, columnsIndex] = new Random().Next(minRandomValue, maxRandomValue);
        }
    }
    return randomArray;
}

static void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($"{array[rows, columns]}");
        }
        Console.WriteLine();
    }
}

static void GetChangedArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, - j];
        array[array.GetLength(0) - 1, - j] = temp;
    }
}

Console.Clear();
int rows = new Random(). Next(1, 10);
int columns = new Random(). Next(1, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRandomValue = new Random().Next(0, 10);
int[,] array = GetArray(rows, columns, minRandomValue, maxRandomValue);

Console.Clear();
PrintArray(array);
Console.WriteLine();
GetChangedArray(array);
PrintArray(array);