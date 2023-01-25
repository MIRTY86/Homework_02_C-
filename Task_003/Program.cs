int[,] randomArray = FillRandomArray();
int columns = randomArray.GetLength(0);
double[] newArr = ArithmArray(columns);
PrintRandomArray(randomArray);
System.Console.WriteLine("***************************************************************************");
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
System.Console.WriteLine($"{String.Join("\t", newArr)} ");


int[,] FillRandomArray()
{

    int[,] randomArray = new int[10, 10];
    var rnd = new Random();
    for (int y = 0; y < 10; y++)
    {
        for (int x = 0; x < 10; x++)
        {
            randomArray[y, x] = rnd.Next(-100, 100);
        }
    }
    return randomArray;
}

void PrintRandomArray(int[,] randomArray)
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

double GetArithmeticMeanColumns(int[,] array, int x)
{
    double sum = 0;
    double res = 0;
    for (int y = 0; y < array.GetLength(0); y++) sum = sum + array[y, x];
    res = sum / array.GetLength(0);
    return res;
}

double[] ArithmArray(int columns)
{
    double[] newArr = new double[columns];
    for (int i = 0; i < columns; i++)
    {
        newArr[i] = GetArithmeticMeanColumns(randomArray, i);
    }
    return newArr;
}

