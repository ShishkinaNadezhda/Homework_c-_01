// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

int num = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(num);

if(numberText.Length > 2)
{
    Console.WriteLine($"Третья цифра {numberText[2]}");
}

else
{
    Console.WriteLine($"У числа {num} нет третьей цифры");
}