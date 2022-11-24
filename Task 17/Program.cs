Console.WriteLine("Введите значение x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y:");
int y = Convert.ToInt32(Console.ReadLine());

int quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}
int q = quarter(x, y);
string result = q > 0 
    ? $"Указанные координаты соответствуют {q} четверти"
    : "введены некорректные координаты";
Console.WriteLine(result);