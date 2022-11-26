// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

void Control(int num)
{
    if (num <= 0) Console.WriteLine("Введите число больше 0");
}


double DegreeOfNumber(int num, int pow)
{
    double result =  Math.Pow(num, pow);
    return result;
}
Control(number);
double result = DegreeOfNumber(number, degree);
if (result > 0) Console.WriteLine($"{number}^{degree} = {result}");