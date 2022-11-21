Console.WriteLine("Введите 1-ое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 > 0)Console.WriteLine($"число {number1} не кратно числу {number2}, остаток {number1 % number2}");
// else Console.WriteLine($"число {number1} кратно числу {number2}");

bool multiplicity(int num1, int num2)
{
    if (num1 % num2 > 0) return true;
    return false;
}

if (multiplicity(number1, number2) == true) Console.WriteLine($"число {number1} не кратно числу {number2}, остаток {number1 % number2}");
else Console.WriteLine($"число {number1} кратно числу {number2}");