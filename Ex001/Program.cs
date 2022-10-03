Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

if (userNumber1 > userNumber2)
{
    Console.Write("{0} Наибольшее число", userInput1);
}
else
{
    Console.Write("{0} Наибольшее число", userInput2);
}

Console.ReadLine();