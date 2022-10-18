// // Напишите программу замены элементы массива: 
// положительные элементы заменить на отрицательные и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = GetArray(5, -9, 9);
PrintArray(array);
Console.WriteLine();
ChangeSign(array);
PrintArray(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i=0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void ChangeSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}
