Console.WriteLine("Введите координату точки А:");
Console.Write("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки В:");
Console.Write("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int by = Convert.ToInt32(Console.ReadLine());

// d = √ (х А – х В) 2 + (у А – у В) 2

double d = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2));

double nRound = Math.Round(d, 2, MidpointRounding.ToZero);
Console.WriteLine(nRound);