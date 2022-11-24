//==================================================================================
// от предыдущего задания различие в 1 символ, по этому сделал универсальную таблицу 
//==================================================================================
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
void control(int num, int pow)
{
    if (num <= 0) Console.WriteLine("Введите число больше 0");
}


void Qwadro(int num, int pow)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i } | { Math.Pow(i, pow)}");
    }
}
control(number, degree);
Qwadro(number, degree);

