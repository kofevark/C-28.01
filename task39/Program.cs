﻿// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
ReversArray1(array); // Перевернули массив первым способом
Console.WriteLine(String.Join(" ", array));
int[] reversArray = ReversArray2(array); // Еще раз меревернули массив вторым способом
Console.WriteLine(String.Join(" ", reversArray));

int[] GetArray(int size, int minValue, int maxValue) // Заполняем массив
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray) // Переворот массива с помощью временной переменной
{
    for (int i = 0; i < inArray.Length / 2; i++) // Доходим только до середины массива
    {
        int k = inArray[i]; // Присваиваем k значение первого элемента
        inArray[i] = inArray[inArray.Length - 1 - i]; // Первому элементу присваиваем значение последнего
        inArray[inArray.Length - 1 - i] = k; // Последнему присваиваем значение k
    }
}

int[] ReversArray2(int[] inArray) // Переворот массива с помощью временного массива
{
    int[] result = new int[inArray.Length]; // Временный массив точно такой же длины, как и начальный
    for (int i = 0; i < inArray.Length; i++) // Проходим по всей длине массива
    {
        result[i] = inArray[inArray.Length - 1 - i]; // Кладем во временный массив значения из начального с конца
    }
    return result;
}