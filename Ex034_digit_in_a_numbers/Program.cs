// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int num = new Random().Next(0, 10000);
Console.WriteLine(num);
int a1 = 0;

while (num > 0)
{
    num/=10;
    a1=a1+1;
}
Console.WriteLine(a1);
