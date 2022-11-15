Console.WriteLine("Введите 2 числа: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 * number_1 == number_2){
    Console.WriteLine($"Число {number_1} является квадратом числа {number_2}");
}
if (number_2 * number_2 == number_1){
    Console.WriteLine($"Число {number_2} является квадратом числа {number_1}");
}
else {
     Console.WriteLine("Квадрат из любого вписаного числа не равняется другому числу");
}