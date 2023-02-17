// Программа принимает на вход число N и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N} -> {GetProductNums(N)}");

int GetProductNums(int N)
{
    int result = 1;
    while (N > 0)
    {
        result = result * N;
        N--;
    }
    return result;
}