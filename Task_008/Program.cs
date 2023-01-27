int m = 5;
int n = 5;
int[,] array = FillRandomArray(m, n);
PrintArray(array);
System.Console.WriteLine("********************************************************************");
int[] sumarray = ArrayOfSumRoow(m);
int Nmin = StringComparison(sumarray);
Console.WriteLine($"Строка с индексом {Nmin}, является строкой с наименьшей суммой элементов. ");



int[,] FillRandomArray(int m, int n)
{

    int[,] randomArray = new int[m, n];

    for (int y = 0; y < m; y++)
    {
        for (int x = 0; x < n; x++)
        {
            randomArray[y, x] = new Random().Next(0, 10);
        }
    }
    return randomArray;
}

void PrintArray(int[,] Array)
{
    for (int y = 0; y < Array.GetLength(0); y++)
    {
        for (int x = 0; x < Array.GetLength(1); x++)
        {
            Console.Write("\t" + Array[y, x]);
        }
        System.Console.WriteLine();
    }
}

int SumOfArrayRoowElements(int[,] array, int y)
{
    int sumElem = 0;
    for (int x = 0; x < array.GetLength(1); x++)
    {
        sumElem = sumElem + array[y, x];
    }
    return sumElem;
}

int[] ArrayOfSumRoow(int m)
{
    int[] sumarray = new int[m];
    for (int i = 0; i < m; i++)
    {
        sumarray[i] = SumOfArrayRoowElements(array, i);
    }
    return sumarray;
}

int StringComparison(int[] sumarray)
{
    int N = 0;
    for (int i = 0; i < sumarray.Length; i++)
    {
        int min = sumarray[sumarray.Length - 1];
        if (sumarray[i] > min)
        {
            min = sumarray[i];
            N = i;
        }
    }
    return N;
}