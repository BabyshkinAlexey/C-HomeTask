Console.WriteLine("Введите 1-ое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num1, int num2, int sum)
{
    if (num1 > num2) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (num1++);
    NaturalNumbers(num1, num2, sum);
}


NaturalNumbers(number1, number2, 0);

