﻿// Программа определяет присутствует ли заданное число в заданном массиве
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// -----
// Инициализация
int size, min, max, num;
int[] array;
Console.Clear();

// -----
// Ввод исходных данных
size = InputNumber("Введите размер массива");
min = InputNumber("Введите минимальное значение в массиве");
max = InputNumber("Введите максимальное значение в массиве");
num = InputNumber("Введите число, которое нужно найти в массиве");

// ------
// Работаем
array = GetArray(size, min, max);
PrintArray(array);
Console.Write($"Число {num} в массиве ");
if (CheckArrayNum(array, num)) Console.WriteLine("присутствует"); else Console.WriteLine("отсутствует");

// -----
// Методы
bool CheckArrayNum(int[] someArray, int checkNum)
{
    // Проверяем наличие числа в массиве
    // На входе массив someArray и число checkNum
    bool flag = false;
    for (int i = 0; i <= someArray.Length - 1; i++) if (someArray[i] == checkNum) flag = true;
    return flag;
}

int[] GetArray(int length, int min = -1, int max = 1)
{
    // Генерирует массив целых чисел заданной длины length
    // По умолчанию числа в массиве от -1 до +1, меняется аргументами min и max
    int[] res = new int[length];
    for (int i = 0; i < length; i++) res[i] = new Random().Next(min, max);
    return res;
}

void PrintArray(int[] someArray)
{
    // Выводит массив в консоль в виде [...]
    Console.Write("[");
    for (int i = 0; i <= someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}

int InputNumber(string message)
{
    // Выводит предолжение message и в ответе получает число. Проверку не производит
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}