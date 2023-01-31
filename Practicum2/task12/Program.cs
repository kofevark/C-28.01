// Программа принимает на вход два числа и выводит, является ли второе число кратным первому. В противом случае выводится остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0) Console.WriteLine($"{num1}, {num2} -> кратно");
else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");