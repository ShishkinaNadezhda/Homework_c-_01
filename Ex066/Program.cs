// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию
//  о том, сколько раз встречается элемент входных данных.
// {1, 9, 9, 0, 2, 8, 0, 9}

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

/*static int GetElement(int[,] array, int number)
{
    int min = number;
    foreach (int element in array)
    {
        if (element < min && element > number)
        min = element;
    }
    return min;
}*/

static int CountElement(int[,] array, int number)
{
    int count = 0;
    
    foreach (int element in array)
    {
       if (element == number)
       {
            count+=1;
       }
    }
    return count;
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


for(int i = minRandomValue; i < maxRandomValue + 1; i++)
{
    int arrayCountNumber = CountElement(array, i);
    if (arrayCountNumber > 0)
    {
        Console.WriteLine($"{i} встречается {arrayCountNumber} раз(а)");
    }
}

/*while(true)
{
    arrayNumber = GetElevtnts(array, arrayNumber);
    Console.WriteLine($"Элемент {arrayNumber}");
    arrayCountNumber = CountElement(array, arrayNumber);
    Console.WriteLine($"Кол-во {arrayNumber}");
    if (arrayCountNumber = 0)
    {
        break;
    }
    else
    {
        Console.WriteLine($"{arrayNumber} встречается {arrayCountNumber} раз(а)");
    }
}*/


