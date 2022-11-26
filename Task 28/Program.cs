Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void control(int num)
{
    if (num <= 0) Console.WriteLine("Введите число больше или меньше 0");
}

int Product(int num)
{
    int result = 1;
    if (num > 0)
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    else 
    for (int i = -1; i >= num; i--)
    {
        result *= i;
    }
    return result;
}
control(number);
int result = Product(number);
if (number > 0) Console.Write($"Произведение чисел от 1 до {number} = {result}");
if (number < 0) Console.Write($"Произведение чисел от -1 до {number} = {result}");
