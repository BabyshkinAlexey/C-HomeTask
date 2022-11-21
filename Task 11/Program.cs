int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное 3-ёх значное число  --> {number}");
int RemuveDigit(int num)
{
    int digit1 = num / 100;
    int digit2 = num / 10 % 10;
    int digit3 = num % 10;
    int result = digit1 * 10 + digit3;
    return result; 
}
//Console.WriteLine($"{digit1}{digit3}");
Console.WriteLine(RemuveDigit(number));