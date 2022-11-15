Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0){
    int number0 = number * (-1);
    for (int i = number0; i <= number; i++){
        Console.WriteLine($"{i}");
    }
}
else if (number < 0){
    int number0 = number * (-1);
    for (int i = number; i <= number0; i++){
        Console.WriteLine($"{i}");
    }
}
else if (number == 0) Console.WriteLine("0");