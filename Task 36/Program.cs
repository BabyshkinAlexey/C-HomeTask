// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Массив будет в диапозоне от 1 до 10 ");
int size = 10;
int[] array = new int[size];
int min = 1;
int max = 10;

void RandomArr(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
}

void PrintArr(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ]");
     Console.WriteLine();
}

int  SerchParity(int[] arr)
{
    int result = 0;
    for(int i = 0; i < size; i++)
    {
        if (i % 2 == 0) result += arr[i];
    } 
    return result;
}
RandomArr(array);
PrintArr(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равняется: {SerchParity(array)}");
