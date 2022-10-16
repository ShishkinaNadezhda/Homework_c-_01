// Напишите программу, которая принимает на вход число (A)
// и выдает сумму числе от 1до A (4 -> (1+2+3+4) ->10)

Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

// Выводит в консоль сообщение message,
// преобразовывает введенную пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
//Возвращает сумму чисел от 1 до number
int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}