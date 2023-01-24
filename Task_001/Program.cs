int minValue = -100;
int maxValue = 100;
int m = EterNumberLines();
int n = EterNumberColumns();
double[,] randomArray = FillUserArray(m, n, minValue, maxValue);
Console.WriteLine($"m = {m}, n = {n}");
Console.WriteLine("******************************************");
PrintUserArray(randomArray);



int EterNumberLines()
{
    int m = 0;
    while (true)
    {
        try
        {
            Console.WriteLine("Введите количество строк массива :");
            m = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception error)
        {
            System.Console.WriteLine($"Введено некоректное значение строк {error.Message}");
        }
    }
    return m;
}

int EterNumberColumns()
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.WriteLine("Введите количество столбцов массива :");
            n = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception error)
        {
            System.Console.WriteLine($"Введено некоректное значение строк {error.Message}");
        }
    }
    return n;
}

double[,] FillUserArray(int m, int n, int minValue, int maxValue)
{

    double[,] randomArray = new double[m, n];

    for (int y = 0; y < m; y++)
    {
        for (int x = 0; x < n; x++)
        {
            randomArray[y, x] = RandomDoubleNumber();
        }
    }
    return randomArray;
}

void PrintUserArray(double[,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write(array[y, x] + "\t");
        }
        System.Console.WriteLine();
    }
}

double RandomDoubleNumber()
{
    Random x = new Random();
    double r = Convert.ToDouble((x.Next(-100, 100)) / 5.0);
    return r;
}
