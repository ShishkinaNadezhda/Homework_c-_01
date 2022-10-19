// Напишите программу, которая переводит десятичное число в двоичное.

int num = EnterNumber();
string Finish = GetNumber(num);
Console.Write(num + " -> " + Finish);

string GetNumber(int N)
{
    string FinishNumber = "";
    while (N > 0)
    {
        int count = N % 2;
        FinishNumber = count + FinishNumber;
        N = N / 2;

    }
    return FinishNumber;
}

int EnterNumber()
{
    int number;
    while(true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number)) break;
        else Console.WriteLine("Ошибка ввода!");
    }
    return number;
}
