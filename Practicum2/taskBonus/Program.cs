// Программа выводит на экран числа от 1 до 100. Вместо чисел, кратных 3, выводится слово "Fizz", а вместо чисел, кратных 5 - слово "Buzz". Если число одновременно кратно 3 и 5, то выводится слово "FizzBuzz"

Console.Clear();
int num = 1;
while (num <= 100)
{
    if (num % 3 == 0 & num % 5 == 0) Console.WriteLine($"{num}-FizzBuzz");
    else
    {
        if (num % 3 == 0) Console.WriteLine($"{num}-Fizz");
        if (num % 5 == 0) Console.WriteLine($"{num}-Buzz");
        if (num % 3 != 0 && num % 5 != 0) Console.WriteLine(num);
    }
    num++;
}