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


// double res1 = 5/2; // res = 2
// double res2 = (double)5/2; // res = 2.5000001 или 2.2999999
// нельзя сравнивать res1 и res2 через ==

// Math.Abs(a-b)<0.00001

// double.Epsilon - наименьшее возможное число, которое сохраняет double