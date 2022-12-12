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
    int[,] matrix = new int[rows, columns];
    matrix[0,0] = arrayA[0,0] * arrayB[0,0] + arrayA[0,1] * arrayB[1,0]; 
    matrix[0,1] = arrayA[0,0] * arrayB[0,1] + arrayA[0,1] * arrayB[1,1];
    matrix[1,0] = arrayA[1,0] * arrayB[0,0] + arrayA[1,1] * arrayB[1,0];
    matrix[1,1] = arrayA[1,0] * arrayB[0,1] + arrayA[1,1] * arrayB[1,1];
    return matrix;
}

Console.WriteLine();
int[,] arreyA = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(arreyA);
Console.WriteLine("    *");
int[,] arreyB = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(arreyB);
Console.WriteLine("    =");
int[,] arreyC =  CreateMatrixC(arreyA, arreyB, 2,2);
PrintMatrix(arreyC);