// Программа принимает на вход число N, на выходе показывает все целые числа от -N до N
Console.Clear();
Console.Write("Введите, пожалуйста, число N: ");
int N = int.Parse(Console.ReadLine()!);
int negativeN = -N;
while (negativeN <= N)
{
    Console.Write(negativeN + " ");
    negativeN++;
}