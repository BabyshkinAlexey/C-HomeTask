// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Summ(int num)
{
    if (num < 0) num *= -1;
    int result = 0;
    int digit = 0;
    while(num != 0)
    {
        digit = num % 10;
        num /=  10;
        result += digit;
    }
    return result;
}
int result = Summ(number);
Console.Write($"Сумма чисел числа {number} = {result} ");