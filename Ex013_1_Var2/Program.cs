// Напишите программу,которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если второе число не кратно первому, то программа выводит остаток от деления.

int EnterNumber()
{
        int number;
        while(true)
        {
            Console.Write("Введите число: ");
            if(int.TryParse(Console.ReadLine(), out number))
                break;
            Console.WriteLine($"Ошибка ввода!");
        }
        return number;
}

int FirstNumber = EnterNumber();
int SecondNumber = EnterNumber();

Console.Write($"{FirstNumber}, {SecondNumber} -> ");
if(FirstNumber % SecondNumber == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {FirstNumber % SecondNumber}");
}
