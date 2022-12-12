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

int SerchMinSum(int[,] matrix)
{
    int minsum = 99;
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            result = i;
            minsum = sum;
        }
    }
    return result;
}

int[,] arrey2D = CreateMatrixRndInt(3, 2, 1, 9);
PrintMatrix(arrey2D);
Console.WriteLine();
int result = SerchMinSum(arrey2D);
Console.WriteLine($"{result + 1}-ая стока имеет в себе эллементы с наименьшей суммой.");