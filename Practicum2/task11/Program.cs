// Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int num = new Random().Next(100, 1000);
int num1 = num / 100;
int num3 = num % 10;
Console.WriteLine($"{num} -> {num1}{num3}");