// Напишите программу, которая переводит десятичное число в двоичное.

int number = UserInput("Введите число: ", "Ошибка!");
int mode;

if (number >= 0) mode = number;
else mode = number * -1;

TransformNumber(number, mode);

static int UserInput(string message, string errormessage)
{
while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int result);
        if (isCorrect)
        {
            return result;
        }
        else
        {
            Console.WriteLine(errormessage);
        }
    }
}

static void TransformNumber(int Input, int modeinput)
{
    int result = 0;
    int number;
    int multiplier = 1;

    while (modeinput > 0)
    {
        number = modeinput % 2;
        modeinput = modeinput / 2;
        result = result + number * multiplier;
        multiplier *=10;
    }
    if (Input >= 0) Console.WriteLine($"Десятичное число транформируется в двоичное {result}");
    else Console.WriteLine($"Десятичное число транформируется в двоичное 1{result}");
}