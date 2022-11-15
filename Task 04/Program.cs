Console.WriteLine("Введите 3 числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Max(Math.Max(number1, number2),number3));