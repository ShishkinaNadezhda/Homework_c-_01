// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите X ");
int X = int.Parse(Console.ReadLine() ?? "");
int a1 = 0;

while (X > 0)
{
    X/=10;
    a1=a1+1;
}
Console.WriteLine(a1);
