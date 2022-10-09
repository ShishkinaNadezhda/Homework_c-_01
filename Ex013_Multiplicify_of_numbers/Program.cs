// Напишите программу,которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если второе число не кратно первому, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

int result = userNumber1 % userNumber2;
if (result == 0)
{
    Console.WriteLine($"{userInput1} кратно {userInput2}");
}
else
{
    Console.WriteLine($"{userNumber1} не кратно {userNumber2}");
}
Console.WriteLine($"Остаток {result}");
