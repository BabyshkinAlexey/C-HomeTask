// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число в диапозоне от -9 до 9: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив будет в диапозоне от -9 до 9 ");

int min = -9;
int max = 9;
int size = 15;

int[] array = new int[size];
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
}

bool Serch(int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}

if (-9 <= number && number <= 9)
{
    RandomArr(array);
    PrintArr(array);
    bool result = Serch(array);
    if (result == true) Console.Write(" --> да");
    else Console.Write(" --> нет");
}
else Console.WriteLine("Введите значение в заданном диапозоне");
