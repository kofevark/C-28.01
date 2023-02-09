// Программа принимает на вход число и выдает количество цифр в числе
// 426 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {GetNumDigits(num)}");

int GetNumDigits(int num)
{
    int number = 0;
    while (num != 0)
    {
        num = num / 10;
        number++;
    }
    return number;
}