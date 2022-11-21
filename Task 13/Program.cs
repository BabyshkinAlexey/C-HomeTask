Console.WriteLine("Введите 3-ёх значное число");
int number = Convert.ToInt32(Console.ReadLine());

int digit(int num)
{
    if (num > 999){
    {
        while(num>999) num /= 10;
    }
    num %= 10;
    return num;}
    else if (num < 100) return 0;
    else return num % 10;
}
if (digit(number) != 0) Console.WriteLine(digit(number));
else Console.WriteLine("третьей цифры нет");