Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number % 10;
Console.WriteLine($"Число {digit} является последней цифрой числа {number}");