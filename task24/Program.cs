// Программа принимает на вход число А и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр равна {GetSumNums(num)}");
Console.WriteLine($"Сумма цифр равна {GetSumNums(num1)}");
Console.WriteLine($"Сумма цифр равна {GetSumNums(num2)}");

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number; // то же самое sum = sum + number
        // Console.Write(sum + " "); // Для контроля можно вывести ход решения
        number--;
    }
    return sum;
}
