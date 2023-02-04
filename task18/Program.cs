// Программа по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x, y)

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int square = int.Parse(Console.ReadLine());
if (square < 1 || square > 4) Console.WriteLine("Четвертей всего четыре");
if (square == 1) Console.WriteLine("Допустимый диапазон для этой четверти: x > 0, y > 0");
if (square == 2) Console.WriteLine("Допустимый диапазон для этой четверти: x < 0, y > 0");
if (square == 3) Console.WriteLine("Допустимый диапазон для этой четверти: x < 0, y < 0");
if (square == 4) Console.WriteLine("Допустимый диапазон для этой четверти: x > 0, y < 0");