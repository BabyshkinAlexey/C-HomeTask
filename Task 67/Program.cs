Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

void SumNumbers (int num, int sum)
{
    int digit = 0;
    if (num == 0)
    {
        if (sum < 0) sum = sum * (-1);
        Console.WriteLine($"{sum}");
        return;
    }
    digit = num % 10;
    sum += digit;
    num /= 10;
    SumNumbers(num, sum);
}

SumNumbers(number, 0);