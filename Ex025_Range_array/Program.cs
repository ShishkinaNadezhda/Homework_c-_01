// Упорядочить массив 6, 8, 3, 2, 1, 4, 5, 7
// Найти min, поменять на 1 место, и так до конца, пока все цифры 
// не встанут на свои места
// Задача:
// 1. Найти позицию минимального элемента в неосортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. повторить, пока есть неосортированные элементы.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[]array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine($"{i}");
    }
    Console.WriteLine();
} 
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int MinPosition = i;
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if(array[i] < array[MinPosition]) MinPosition = j;
        }
        int temporary = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temporary;
    }
}
PrintArray (arr);
SelectionSort(arr);
PrintArray(arr);