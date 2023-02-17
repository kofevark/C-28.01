// Программа принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// Например:
// A (3, 6) B (2, 1) -> 5,09
// A (7, -5) B (1, -1) -> 7,21

Console.Clear();
Console.Write("Введите координату x для точки А: ");
int Ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y для точки А: ");
int Ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату x для точки B: ");
int Bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y для точки B: ");
int By = int.Parse(Console.ReadLine()!);
double S = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2)), 2);
Console.WriteLine("Расстояние между этими точками равно " + S);