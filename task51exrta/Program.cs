// Задать двумерный массив.
// Найти сумму всех четных элементов, стоящих на нечетных местах

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine($"Сумма всех четных элементво, стоящих на нечетных местах в этом массиве = {FindSumPositiveElements(array)}");

int[,] GetArray(int tempRows, int tempColumns)
{
    int[,] someArray = new int[tempRows, tempColumns];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            someArray[i, j] = new Random().Next(0, 10);
        }
    }
    return someArray;
}

int FindSumPositiveElements(int[,] someArray)
{
    int result = 0;
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            if (someArray[i, j] % 2 == 0 & (i % 2 != 0 || j % 2 != 0)) result += someArray[i, j];
        }
    }
    return result;
}

void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}