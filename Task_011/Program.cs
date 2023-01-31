string message1 = "Введите N :";
int start = CheckNumber(message1);

int CheckNumber(string message)
{
    int a = 0;
    while (true)
    {
        try
        {
            System.Console.WriteLine(message);
            a = int.Parse(Console.ReadLine() ?? "");
            break;

        }
        catch (Exception exc)
        {
            System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
        }
    }
    return a;
}

Console.Write("N = " + start + " --> " + "\" ");
DisplayNumbers(start);
Console.WriteLine("\"");

void DisplayNumbers(int n)
{
    if (n >= 1)
    {
        Console.Write(n + " ");
        DisplayNumbers(n - 1);
    }
}
