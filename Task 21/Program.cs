// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А:");
Console.Write("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В:");
Console.Write("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int bz = Convert.ToInt32(Console.ReadLine());

//l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2.

double d = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2) + Math.Pow(bz-az, 2));

double nRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(nRound);