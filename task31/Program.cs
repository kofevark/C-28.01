// Задайте массив из 12 элементов, заполненных случацйными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных элементов равна 29, 
// сумма отрицательных навна -20.

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue) // Объявили универсальный метод. Позволит создать, заполнить и напечатать массив любого размера в любом диапазоне чисел
{
    int[] res = new int[size]; // Создали новый массив
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // Кладем в массив случайные элементы от minValue до maxValue
        Console.Write($"{res[i]} "); // Печатаем массив для проверки
    }
    return res; // Возвращаем полученный результат
}

int[] array = GetArray(12, -9, 9); // Зовем метод и говорим ему, что размер будет 12 и диапазон от -9 до 9
int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array) // Перебираем все элементы (el) массива array по очереди
{
    if (el > 0)
    {
        positiveSum += el;
    }
    else
    {
        negativeSum += el;
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных числе = {positiveSum} ");
Console.WriteLine($"Сумма отрицательных числе = {negativeSum} ");