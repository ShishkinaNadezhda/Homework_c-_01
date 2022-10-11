// Метод, вид 2, второй вариант
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        i++;
        Console.WriteLine(msg);
    }
}

Method2(count: 4, msg: "Новый текст");
// или Method2("Текст", 4);
// или Method2(msg:"Текст", count: 4);
// или Method2(count: 4, msg: "Новый текст");
// если зациклилось, нажимаем Ctrl+C