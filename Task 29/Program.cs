// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
// int size = 8;
// int[] array = new int[size];

// void RandomArr(int[] arr)
// {
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите значение {i+1} эллемента: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// void PrintArr(int[] arr)
// {
//      Console.Write("[");
//     for (int i = 0; i < size; i++)
//     {
//         if (i == size - 1) Console.Write($"{arr[i]}");
//         else Console.Write($"{arr[i]}, ");
//     }
//      Console.Write("]");
// }
// RandomArr(array);
// PrintArr(array);
//==============================================================================

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void RandomArr(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 101);
        Console.Write($"[{array[i]}] ");
    }
}

if (size > 0)
{
    Console.WriteLine("Числа будут выведены в диапозоне от 1 до 100");
    RandomArr(array);
}
else Console.WriteLine("Размер массива не может быть меньше или равен 0");