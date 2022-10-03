// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

Console.Write("Введите третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNumber3 = int.Parse(userInput3);

int MaxUserNumber;

if (userNumber1 > userNumber2)
    {
        MaxUserNumber = userNumber1;
    }
else 
    {
        MaxUserNumber = userNumber2;
    }
if (userNumber1 > userNumber3)
    {
        MaxUserNumber = userNumber1;
    }
else 
    {
        MaxUserNumber = userNumber3;
    }
if (userNumber2 > userNumber3)
    {
        MaxUserNumber = userNumber2;
    }
else 
    {
        MaxUserNumber = userNumber3;
    }

Console.WriteLine("{0} - наибольшее число из трёх", MaxUserNumber);
Console.ReadLine();