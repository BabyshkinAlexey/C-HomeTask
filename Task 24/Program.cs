Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Summ(int num)
{
    int result = 0;
    for(int i = 1; i <= num; i++)
    {
        result += i;
    }
    return result;
}
int summ = Summ(number);

if (summ <= 0)Console.WriteLine("Введите число больше 0");

else Console.WriteLine($"Сумма чисел от 1 до {number} = {summ}");