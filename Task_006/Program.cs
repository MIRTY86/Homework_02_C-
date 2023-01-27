int[,] randomArray = FillRandomArray();
PrintRandomArray(randomArray);
Console.WriteLine();
PrintResult(randomArray);


void PrintResult(int[,] array)
{
    for (int i = 0; i < 11; i++)
    {
        int num = CountElement(i, array);
        if(num == 2 || num == 3 || num == 4) Console.WriteLine($"{i} встречается {num} раза.");
        else Console.WriteLine($"{i} встречается {num} раз.");
    }
}

int[,] FillRandomArray()
{

    int[,] randomArray = new int[5, 5];

    for (int y = 0; y < 5; y++)
    {
        for (int x = 0; x < 5; x++)
        {
            randomArray[y, x] = new Random().Next(0, 11);
        }
    }
    return randomArray;
}

int CountElement(int num, int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j]) result++;
        }
    }
    return result;
}

void PrintRandomArray(int[,] Array)
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