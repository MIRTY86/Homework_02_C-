int[,] array = new int[9, 13];

FillArraySpiral(array);
PrintRandomArray(array);

int[,] FillArraySpiral(int[,] array)
{
    int Num = 0;
    int y = 0;
    int x = 0;
    while (x + 1 < array.GetLength(1))
    {
        FillElement(array, y, x, Num);
        x++;
        Num++;
    }

    while (y + 1 < array.GetLength(0))
    {
        FillElement(array, y, x, Num);
        y++;
        Num++;
    }

    while (x > 0)
    {
        FillElement(array, y, x, Num);
        x--;
        Num++;
    }

    while (array[y, x] == 0 || array[y - 1, x] == 0)
    {
        while (array[y - 1, x] == 0)
        {
            FillElement(array, y, x, Num);
            y--;
            Num++;
        }

        while (array[y, x + 1] == 0 && array[y, x] == 0)
        {
            FillElement(array, y, x, Num);
            x++;
            Num++;
        }

        while (array[y, x] == 0 && array[y + 1, x] == 0)
        {
            FillElement(array, y, x, Num);
            y++;
            Num++;
        }

        while (array[y, x] == 0)
        {
            FillElement(array, y, x, Num);
            x--;
            Num++;
        }
        x++;
        y--;
    }
    return array;
}
int[,] FillElement(int[,] array, int y, int x, int num)
{
    array[y, x] = num + 1;
    num++;
    return array;
}

void PrintRandomArray(int[,] Array)
{
    for (int y = 0; y < Array.GetLength(0); y++)
    {
        for (int x = 0; x < Array.GetLength(1); x++)
        {
            Console.Write(Array[y, x] + "\t");
        }
        System.Console.WriteLine();
    }
}