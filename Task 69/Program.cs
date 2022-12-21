Console.WriteLine("Введите 1-ое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int DegreeNumbers(int num, int degree)
{
    return degree == 0 ? 1 : DegreeNumbers(num, degree - 1) * num;
}

Console.WriteLine(DegreeNumbers(number1, number2));