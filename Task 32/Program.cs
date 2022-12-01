/*
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив будет в диапозоне от -9 до 9 ");
int[] array = new int[size];
int min = -9;
int max = 9;

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

void Inversion(int[] arr)
{   
    for (int i = 0; i < size; i++) arr[i] *= -1;
}

RandomArr(array);
PrintArr(array);
Console.WriteLine("Инверсия:");
Inversion(array);
PrintArr(array);
