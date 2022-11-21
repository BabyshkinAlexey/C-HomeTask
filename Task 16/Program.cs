Console.WriteLine("Введите 1-ое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool sqrtF(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1) return true;
    return false;
}
Console.WriteLine(sqrtF(number1, number2) ? "YES" : "NO");