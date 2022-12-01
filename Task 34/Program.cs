// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив будет в диапозоне от 100 до 999 ");
int[] array = new int[size];
int min = 100;
int max = 999;

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

int Parity(int[] arr)
{
    int result = 0;
    for(int i = 0; i < size; i++)
    {
        if (arr[i] % 2 == 0) result ++;
    } 
    return result;
}
RandomArr(array);
PrintArr(array);
Console.WriteLine($"Количество чётных чисел в массиве = {Parity(array)}");