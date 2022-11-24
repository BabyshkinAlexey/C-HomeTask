// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-ти значное число:");
int number = Convert.ToInt32(Console.ReadLine());
// 01 2 34
bool Result(int num)
{
    int digit0 = num / 10000;
    int digit1 = num / 1000 % 10;
    int digit3 = num % 100 / 10;
    int digit4 = num % 10;
    if (digit0 == digit4 && digit1 == digit3) return true;
    else return false;
}

int ControlNum(int num)
{
    if (num < 100000 && num > 9999) return 1;
    else return 0;
}

if (ControlNum(number) == 1)
{
    string result = Result(number) ? "число является палиндромом" : "число не является палиндромом";
    Console.WriteLine(result);
}
else Console.WriteLine("Введено неккоректное число");
