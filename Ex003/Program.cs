// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if (userNumber % 2 == 0)
 {
    Console.Write("Введенное число является четным");
    Console.Read();
 }
 else
 {
    Console.Write("Введенное число нечетное");
    Console.Read();
 }