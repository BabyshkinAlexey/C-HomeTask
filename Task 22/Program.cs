Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Введите число больше 0");
}
void Qwadro(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i } --> { Math.Pow(i, 2)}");
    }
}
Qwadro(number);
