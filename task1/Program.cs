// Проверка, является ли первое число квадратом второго
Console.Clear();
Console.Write("Введите, пожалуйста, число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите, пожалуйста, число b: ");
int b = int.Parse(Console.ReadLine());
if (b * b == a) Console.WriteLine("Ура, число a является квадратом числа b!");
else Console.WriteLine("Число a не является квадратом числа b");