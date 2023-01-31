// Программа выводит на экран числа от 1 до 100. Вместо чисел, кратных 3, выводится слово "Fizz", а вместо чисел, кратных 5 - слово "Buzz". Если число одновременно кратно 3 и 5, то выводится слово "FizzBuzz"

Console.Clear();
int num = 1;
while (num <= 100)
{
    Console.BackgroundColor = ConsoleColor.Gray;
    // Сброс цвета фона на цвет по умолчанию
    // Console.ResetColor(); 
    if (num % 3 == 0 & num % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FizzBuzz");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        if (num % 3 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Fizz");
            Console.ForegroundColor = ConsoleColor.White;
        }
        if (num % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Buzz");
            Console.ForegroundColor = ConsoleColor.White;
        }
        if (num % 3 != 0 && num % 5 != 0) Console.Write(num);
    }
    if (num == 100) Console.Write(".");
    else Console.Write(", ");
    num++;
}