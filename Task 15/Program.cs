Console.WriteLine("Введите число, обозначающее день недели");
int number = Convert.ToInt32(Console.ReadLine());
bool weekend(int num)
{
    if (num == 6 || num == 7) return true;
    return false;
}
Console.WriteLine(weekend(number) ? "YES" : "NO");