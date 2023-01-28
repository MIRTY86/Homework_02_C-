int m = 2;
int n = 5;
int k = 9;
int[,,] matrix = FillRandomMatrix(m, n, k);
PrintMatrix(matrix);


int[,,] FillRandomMatrix(int m, int n, int k)
{
    int[,,] randomMatrix = new int[m, n, k];

    for (int y = 0; y < randomMatrix.GetLength(0); y++)
    {
        for (int x = 0; x < randomMatrix.GetLength(1); x++)
        {
            for (int z = 0; z < randomMatrix.GetLength(2); z++)
            {
                while (true)
                {
                    int rnd = new Random().Next(10, 100);
                    bool res = ElementsCheckMatrix(randomMatrix, rnd);
                    if (res)
                    {
                        randomMatrix[y, x, z] = rnd;
                        break;
                    }
                }
            }
        }
    }
    return randomMatrix;
}

bool ElementsCheckMatrix(int[,,] randomMatrix, int rnd)
{
    bool log = true;
    for (int z = 0; z < randomMatrix.GetLength(0); z++)
    {
        for (int y = 0; y < randomMatrix.GetLength(1); y++)
        {
            for (int x = 0; x < randomMatrix.GetLength(2); x++)
            {
                if (randomMatrix[z, y, x] == rnd)
                {
                    log = false;
                    break;
                }
            }
        }
    }
    return log;
}

void PrintMatrix(int[,,] Matrix)
{
    for (int z = 0; z < Matrix.GetLength(0); z++)
    {
        for (int y = 0; y < Matrix.GetLength(1); y++)
        {
            for (int x = 0; x < Matrix.GetLength(2); x++)
            {
                Console.Write($"[{z}.{y}.{x}] : ");
                Console.Write(Matrix[z, y, x] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
