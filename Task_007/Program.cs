int[,] array = FillRandomArray();
System.Console.WriteLine("Random array :");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Sorted array :");
int[,] newArray = SortMaxMinElemets(array);
PrintArray(newArray);


int[,] FillRandomArray()
{

    int[,] randomArray = new int[5, 5];

    for (int y = 0; y < 5; y++)
    {
        for (int x = 0; x < 5; x++)
        {
            randomArray[y, x] = new Random().Next(0, 51);
        }
    }
    return randomArray;
}

void PrintArray(int[,] randomArray)
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

int[,] SortMaxMinElemets(int[,] array)
{

    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[y, x] < array[y, x + 1])
                {
                    int temp = array[y, x];
                    array[y, x] = array[y, x + 1];
                    array[y, x + 1] = temp;
                }
            }


        }
    }
    return array;
}



