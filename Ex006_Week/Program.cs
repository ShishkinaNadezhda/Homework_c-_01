// Задача про дни недели. При вводе порядкового числа дня недели выводить название дня недели.
Console.Write("Введите номер дня недели: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if(userNumber == 1)
{
    Console.WriteLine("Понедельник");
}
if(userNumber == 2)
{
    Console.WriteLine("Вторник");
}
if(userNumber == 3)
{
    Console.WriteLine("Среда");
}
if(userNumber == 4)
{
    Console.WriteLine("Четверг");
}
if(userNumber == 5)
{
    Console.WriteLine("Пятница");
}
if(userNumber == 6)
{
    Console.WriteLine("Суббота");
}
if(userNumber == 7)
{
    Console.WriteLine("Воскресенье");
}
if(userNumber > 7)
{
    Console.Write("В неделе всего семь дней");
}