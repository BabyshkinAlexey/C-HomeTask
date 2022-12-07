Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int size)
{
    int[] arr = new int[size];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}
void PrintArr(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ]");
    Console.WriteLine();
}

PrintArr(Fibonacci(number));
