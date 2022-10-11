// Метод вид 4 - что-то принимает, что-то возвращает, 
// самый распространенный метод

string Method4(int count, string c)
{
    int i = 0;
    string result = "";
    // или string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
