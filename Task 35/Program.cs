Console.WriteLine("Массив будет в диапозоне от 1 до 150 ");
int size = 123;
int[] array = new int[size];
int min = 1;
int max = 150;

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

int  Serch10before99(int[] arr)
{
    int result = 0;
    for(int i = 0; i < size; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) result ++;
    } 
    return result;
}
RandomArr(array);
PrintArr(array);
Console.WriteLine($"Количество чисел в диапозоне то 10 до 99 равняется: {Serch10before99(array)}");