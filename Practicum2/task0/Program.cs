// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

Console.Clear();
int random = new Random().Next(10, 100);
Console.WriteLine(random);
int firstNumber = random / 10;
int secondNumber = random % 10;
if (firstNumber > secondNumber) Console.WriteLine(random + " -> " + firstNumber);
else Console.WriteLine(random + " -> " + secondNumber);