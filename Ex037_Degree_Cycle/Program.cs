// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
double S = 1;

Console.Write("Введите кол-во повторов: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    S *= x;
}
Console.WriteLine(S);
