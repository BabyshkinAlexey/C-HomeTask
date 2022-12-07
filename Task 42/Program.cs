Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Binary(int num, int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = num % 2;
            num /= 2;
            // Console.Write($"[{arr[i] }] ");
        }
    return arr;
}

int Size(int num)
{
    int length = 0;
    while (num > 0)
    {
        num /= 2;
        length ++;
    }
    return length;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"[{arr[i]}] ");
        else Console.Write($"[{arr[i]}] ");
    }
}

int length = Size(number);
int[] result = Binary(number, length);
Console.WriteLine($"Число {number} в двоичном представлении: ");
Array.Reverse(result);
PrintArr(result);
