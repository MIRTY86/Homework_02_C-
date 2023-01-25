string Y = "Введите первое значение индекса элемента : ";
string X = "Введите второе значение индекса элемента : ";
int y = UserEnterPosition(Y);
int x = UserEnterPosition(X);
double[,] array = FillRandomArray();
double element = SearchArrayElement(array, y, x);
PrintTestResult(element);


int UserEnterPosition(string message)
{
    int pos = 0;
    while (true)
    {
        try
        {
            Console.Write(message);
            pos = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception error)
        {
            System.Console.WriteLine($"Введено некоректное значение индекса {error.Message}");
        }
    }
    return pos;
}

double[,] FillRandomArray()
{

    double[,] randomArray = new double[15, 15];

    for (int y = 0; y < 15; y++)
    {
        for (int x = 0; x < 15; x++)
        {
            randomArray[y, x] = RandomDoubleNumber();
        }
    }
    return randomArray;
}

double RandomDoubleNumber()
{
    Random x = new Random();
    double r = Convert.ToDouble((x.Next(-100, 100)) / 5.0);
    return r;
}

double SearchArrayElement(double[,] array, int y, int x)
{
    double element = 0;
    if (y > array.GetLength(0)) return 0;
    if (x > array.GetLength(1)) return 0;
    else
    {
        element = array[y, x];
    }
    return element;
}

void PrintTestResult(double element)
{
    if (element == 0) Console.WriteLine($"Элемента с индексом [{y},{x}] в массиве нет.");
    else System.Console.WriteLine($"Элемент на позиции [{y}.{x}] = " + element);
}