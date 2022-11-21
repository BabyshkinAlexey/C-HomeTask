 int number = new Random().Next(10, 100);
 console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");
 int firstdigit = number / 10;
 int seconddigit = number % 10;
 if (firstdigit > seconddigit) Console.WriteLine($"Наибольшая цифра --> {firstdigit}");
 else ($"Наибольшая цифра --> {seconddigit}");
