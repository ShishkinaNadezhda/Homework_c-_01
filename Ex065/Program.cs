// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
//        int[,] tempArray = new int [array.GetLength(0), array.GetLength(1)];
        for (int j = i; j < array.GetLength(1); j++)
        {
//            tempArray[i, j] = array[i, j];
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

static bool ArrayCheck(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
        return true;
    return false;
}

Console.Clear();
//int rows = new Random(). Next(1, 10);
//int columns = new Random(). Next(1, 10);
int rows = 4;
int columns = 4;
int minRandomValue = new Random().Next(-9, 0);
int maxRandomValue = new Random().Next(0, 10);
int[,] array = GetArray(rows, columns, minRandomValue, maxRandomValue);

Console.Clear();
PrintArray(array);
Console.WriteLine();


bool check = ArrayCheck(array);
if (check)
{
    GetChangedArray(array);
    PrintArray(array);
}
else
{
    {
        Console.WriteLine("Невозможно изменить массив");
    }
}
