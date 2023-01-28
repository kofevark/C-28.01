// Программа принимает на входе трехзначное число, на выходе показывает последнюю цифру этого числа
Console.Clear();
Console.Write("Введите, пожалуйста, трехзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(number%10);
