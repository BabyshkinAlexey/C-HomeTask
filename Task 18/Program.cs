Console.WriteLine("Введите значение четверти");
int number = Convert.ToInt32(Console.ReadLine());

string Range(int digit)
{
    if (digit == 1) return "x > 0 and y > 0";
    if (digit == 2) return "x < 0 and y > 0";
    if (digit == 3) return "x < 0 and y < 0";
    if (digit == 4) return "x > 0 and y < 0";
    return "введены некорректный номер четверти";
}
string range = Range(number);
Console.WriteLine(range);
