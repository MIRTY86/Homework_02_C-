int m = 5;
int n = 5;

double[,] array = FillUserArray(m, n);
PrintRandomArray(array);
System.Console.WriteLine();
ChangeArray(array);
PrintRandomArray(array);


void ChangeArray(double[,] array)
{
    for (int x = 0; x < array.GetLength(1); x++)
    {
        double temp = array[0, x];
        array[0, x] = array[array.GetLength(0) - 1, x];
        array[array.GetLength(0) - 1, x] = temp;
    }
}

void PrintRandomArray(double[,] randomArray)
{
    for (int y = 0; y < randomArray.GetLength(0); y++)
    {
        for (int x = 0; x < randomArray.GetLength(1); x++)
        {
            Console.Write(randomArray[y, x] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] FillUserArray(int m, int n)
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

double RandomDoubleNumber()
{
    Random x = new Random();
    double r = Convert.ToDouble((x.Next(-100, 100)) / 5.0);
    return r;
}