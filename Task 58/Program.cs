int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("]");
    }
}

int[,] CreateMatrixC(int[,] arrayA, int[,] arrayB, int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        int sum = 0;
        for (int k = 0; k < columns; k++)
        {
            sum += arrayA[i,k] * arrayB[k,j];
        }
        resultMatrix[i,j] = sum;
        }
    }
    return resultMatrix;
}

Console.WriteLine();
int[,] arreyA = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(arreyA);
Console.WriteLine("    *");
int[,] arreyB = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(arreyB);
Console.WriteLine("    =");
int[,] arreyC =  CreateMatrixC(arreyA, arreyB, 3, 3);
PrintMatrix(arreyC);

