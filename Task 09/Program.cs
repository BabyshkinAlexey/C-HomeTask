int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");
// int firstdigit = number / 10;
// int seconddigit = number % 10;
// if (firstdigit > seconddigit) Console.WriteLine($"Наибольшая цифра --> {firstdigit}");
// else Console.WriteLine($"Наибольшая цифра --> {seconddigit}");

int MaxDigit(int num)
{
    int firstdigit = num / 10;
    int seconddigit = num % 10;
    if (firstdigit > seconddigit) return firstdigit;
    return seconddigit;
    // int max firstdigit > seconddigit ? firstdigit : seconddigit
    // переменная = условие ? значение если истина : значение если ложь
}
int maxdigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра --> {maxdigit}");