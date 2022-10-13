// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D-пространстве.
// А(3, 6), В(2, 1) -> 5,09
// А(7, -5), В(1, -1) -> 7.21

int a1, b1, a2, b2;

a1 = Coords("Введите координату x первой точки: ");
a2 = Coords("Введите координату y первой точки: ");
b1 = Coords("Введите координату x второй точки: ");
b2 = Coords("Введите координату y второй точки: ");

static int Coords(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int a1, int a2, int b1, int b2)
{
    double result = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2));
    return result;
}


double dist = Distanse(a1, a2, b1, b2);
Console.WriteLine(dist);