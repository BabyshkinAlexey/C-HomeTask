Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool multiplicity(int num)
{
    if (num % 7 == 0 && num % 23 == 0) return true;
    return false;
}
Console.WriteLine(multiplicity(number) ? "YES" : "NO");