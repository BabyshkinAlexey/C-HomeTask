
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
void RandomArr(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
}

int SerchSumP(int[] arr)
{
    int resultP = 0;
    for (int i = 0; i < size; i++)
        if (arr[i] > 0) resultP += arr[i];
    return resultP;
}

int SerchSumM(int[] arr)
{
    int resultM = 0;
    for (int i = 0; i < size; i++)
        if (arr[i] < 0) resultM += arr[i];
    return resultM;
}

void PrintArr(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
     Console.WriteLine();
}

RandomArr(array);
Console.WriteLine("      Массив:");
PrintArr(array);
int sumP = SerchSumP(array);
int sumM = SerchSumM(array);
Console.WriteLine($"Сумма положительных эллементов равна: {sumP}");
Console.WriteLine($"Сумма отрицательных эллементов равна: {sumM}");
