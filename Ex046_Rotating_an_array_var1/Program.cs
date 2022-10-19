// Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем)
// [1, 2, 3, 4, 5] -> [5< 4, 3, 2, 1]

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(" ", array));

int[] reversArray = ReversArray1(array);
Console.WriteLine(string.Join(" ", reversArray));

ReversArray2(array);
Console.WriteLine(string.Join(" ", array));

int i = 0;

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ReversArray1(int[] InArray)
{
    int[] result = new int[InArray.Length];
    for (int i = 0; i < InArray.Length; i++)
    {
        result[i] = InArray[InArray.Length - 1 - i];
    }
    return result;
}

void ReversArray2(int[] InArray)
{
    for (int i = 0; i < InArray.Length / 2; i++)
    {
        int k = InArray[i];
        InArray[i] = InArray[InArray.Length - i - 1];
        InArray[InArray.Length - i - 1] = k;
    }
}
