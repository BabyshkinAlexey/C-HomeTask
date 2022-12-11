// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

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

int[,] CreateModifiedMatrix(int[,] matrix)
{

    int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[i, j] = matrix[j, i];
        }
    }
    return matrix2;
}

int[,] arrey2D = CreateMatrixRndInt(rows, colums, 1, 9);
if (arrey2D.GetLength(0) != arrey2D.GetLength(1)) Console.WriteLine("Замена не возможна.");
else
{

    PrintMatrix(arrey2D);
    Console.WriteLine();
    int[,] matrix2 = CreateModifiedMatrix(arrey2D);
    PrintMatrix(matrix2);
}