Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool TriangleInequality(int aT, int bT, int cT)
{
    if ((aT < bT + cT) && (bT < aT + cT) && (cT < aT + bT))
    return true;
    else return false;
}

if (TriangleInequality(a, b, c) == true) Console.WriteLine("Треугольник существует с сторонами такой длины");
else Console.WriteLine("Треугольник НЕ существует с сторонами такой длины");