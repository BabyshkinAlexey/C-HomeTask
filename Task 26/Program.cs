Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Quantity(int num)
{
    int result = 0;
    while(num != 0)
    {
        num = num / 10;
        result += 1;
    }
    return result;
}
int result = Quantity(number);
if (result > 0) Console.Write($"В числе {number} количество цифр равно {result}");
else if (number == 0) Console.Write($"В числе {number} количество цифр равно 1");