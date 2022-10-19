// Напишите программу, которая переводит десятичное число в двоичное.

int number = UserInput("Введите число: ", "Ошибка!");

TransformNumber(number);

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

static void TransformNumber(int Input)
{
    int result = 0;
    int number;
    int multiplier = 1;

    while (Input > 0)
    {
        number = Input % 2;
        Input = Input / 2;
        result = result + number * multiplier;
        multiplier *=10;
    }

    Console.WriteLine($"Десятичное число транформируется в двоичное {result}");
}