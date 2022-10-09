// Напишите программу которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число  {num}");

int a1 = num / 100;
Console.WriteLine($"Первая цифра случайного числа  {a1}");

int a2_1 = num % 100;
int a2 = a2_1 / 10;
Console.WriteLine($"Вторая цифра случайного числа  {a2}");

int a3 = a2_1 % 10;
Console.WriteLine($"Третья цифра случайного числа  {a3}");

int a4 = a1 * 10;
int a5 = a4 + a3;
Console.WriteLine($"Ответ {a5}");
