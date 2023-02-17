// Программа принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 * num1 == num2 || num2 * num2 == num1) Console.WriteLine($"{num1}, {num2} -> да");
else Console.WriteLine($"{num1}, {num2} -> нет");