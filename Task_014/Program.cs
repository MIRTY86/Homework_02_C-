string message1 = "Введите число m";
string message2 = "Введите число n";

int n = CheckNumber(message1);
int m = CheckNumber(message2);

int resAk = Akerman(n,m);
Console.WriteLine($"m = {n}, n = {m} --> A({n},{m}) = {resAk}");

int CheckNumber(string mes)
{
    int num = 0;
    while (true)
    {
        try
        {
            System.Console.WriteLine(mes);
            num = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception error)
        {
            System.Console.WriteLine("Неверный формат данных! " + error.Message);
        }

    }
    return num;
}
int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akerman(n - 1, 1);
    if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
    return Akerman(n, m);
}
