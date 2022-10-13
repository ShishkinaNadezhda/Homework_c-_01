// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int a1, b1, a2, b2, c1, c2;

a1 = Coords("Введите координату x первой точки: ");
b1 = Coords("Введите координату y первой точки: ");
c1 = Coords("Введите координату z первой точки: ");
a2 = Coords("Введите координату x второй точки: ");
b2 = Coords("Введите координату y второй точки: ");
c2 = Coords("Введите координату z второй точки: ");

static int Coords(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int a1, int a2, int b1, int b2, int c1, int c2)
{
    double result = Math.Sqrt(Math.Pow(a2 - a1, 2)
                  + Math.Pow(b2 - b1, 2)
                  + Math.Pow(c2 - c1, 2));
    return result;
}

double dist = Distanse(a1, a2, b1, b2, c1, c2);
Console.WriteLine(dist);