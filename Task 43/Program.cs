// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//       заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
Double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
Double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
Double b2 = Convert.ToDouble(Console.ReadLine());
 
 
Double x = -(b1 - b2) / (k1 - k2);
Double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ( {x} ; {y} )");
