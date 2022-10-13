// Напишите программу, которая по заданному номеру четверти 
// показывает диапазон возможных координат точек в этой четверти  (x, y).

static void Quarter(int quart)
{
if (quart == 1)
    Console.WriteLine("x > 0, y > 0");
else if (quart == 2)
    Console.WriteLine("x < 0, y > 0");
else if (quart == 3)
    Console.WriteLine("x < 0, y < 0");
else if (quart == 4)
    Console.WriteLine("x > 0, y < 0");
else Console.Write("Укажите корректную четверть!");
}

int quart;
Console.WriteLine("Введите номер четверти ");
quart = int.Parse(Console.ReadLine() ?? "");

Quarter(quart);