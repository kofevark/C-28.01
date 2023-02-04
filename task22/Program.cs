// Программа принимает на вход число N и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.Clear();
Console.WriteLine();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
Console.Write($"{num} ->");
while (count < num)
{
    Console.Write($" {Math.Pow(count, 2)},");
    count++;
}
Console.Write($" {Math.Pow(count, 2)}.");