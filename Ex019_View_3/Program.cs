// Метод вид 3 - ничего не принимает, что-то возвращает/
// Например, эта программа выводит текущий год.
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
