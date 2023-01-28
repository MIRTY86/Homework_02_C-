string Message1 = "Введите число строк матрицы B : ";
string Message2 = "Введите число столбцов матрицы B : ";
string Message3 = "Введите число строк матрицы С : ";
string Message4 = "Введите число столбцов матрицы С : ";
string Message5 = "Матрица B";
string Message6 = "Матрица С";
string Message7 = "Результат умножения матриц B и С";
int rowsB = ValueCheck(Message1);
int columnsB = ValueCheck(Message2);
int rowsC = ValueCheck(Message3);
int columnsC = ValueCheck(Message4);

int[,] MatrixB = FormationRandomMatrix(rowsB, columnsB);
int[,] MatrixC = FormationRandomMatrix(rowsC, columnsC);

System.Console.WriteLine("**********************************************************");
if (PossibilityCheckMatrix(MatrixB, MatrixC))
{
    int[,] MatrixA = MatrixMultiplication(MatrixB, MatrixC);
    PrintMatrix(MatrixB, Message5);
    System.Console.WriteLine();
    PrintMatrix(MatrixC, Message6);
    System.Console.WriteLine();
    PrintMatrix(MatrixA, Message7);
}
else
{
    System.Console.WriteLine("Матрица B и C не совместимы!!!");
    System.Console.WriteLine("Введите корректные значения столбцов и строк матриц.");
    return;
}


int ValueCheck(string mes)
{
    int a = 0;
    while (true)
    {
        try
        {
            System.Console.Write(mes);
            a = int.Parse(Console.ReadLine() ?? "");
            break;

        }
        catch (Exception exc)
        {
            System.Console.WriteLine($"Ошибка ввода данных!!! {exc.Message}");
        }
    }
    return a;
}

bool PossibilityCheckMatrix(int[,] MatrixB, int[,] MatrixC)
{
    if (MatrixB.GetLength(1) == MatrixC.GetLength(0)) return true;
    else return false;
}

int[,] FormationRandomMatrix(int rows, int columns)
{
    int[,] randomMatrix = new int[rows, columns];

    for (int y = 0; y < rows; y++)
    {
        for (int x = 0; x < columns; x++)
        {
            randomMatrix[y, x] = new Random().Next(0, 11);
        }
    }
    return randomMatrix;
}

void PrintMatrix(int[,] Matrix, string mes)
{
    Console.WriteLine("**********" + mes + " **********");
    for (int y = 0; y < Matrix.GetLength(0); y++)
    {
        for (int x = 0; x < Matrix.GetLength(1); x++)
        {
            Console.Write(Matrix[y, x] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] MatrixB, int[,] MatrixC)
{
    int[,] newMatrix = new int[MatrixB.GetLength(0), MatrixC.GetLength(1)];
    for (int i = 0; i < MatrixB.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixC.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixC.GetLength(0); k++)
            {
                newMatrix[i, j] += MatrixB[i, k] * MatrixC[k, j];
            }
        }
    }
    return newMatrix;
}