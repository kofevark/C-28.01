// Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного 
// копирования.

Console.Clear();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i]);
}
Console.WriteLine();
foreach (int el in array)
{
    Console.Write(el);
}
Console.WriteLine();
