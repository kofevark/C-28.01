// Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

// Инициализация переменных
int number1 = InputNum("ВВедите первое число");
int number2 = InputNum("ВВедите второе число");
int number3 = InputNum("ВВедите третье число");

// Вызов рабочего метода и проверка
if (CheckTriangle(number1, number2, number3)) Console.WriteLine("Это может быть треугольником"); // Если проверочный метод вернул true, печатаем да
else Console.WriteLine("Это не может быть треугольником"); // Если проверка не удалась

// Методы
int InputNum(string message) // Метод для ввода значений
{
    Console.Write($"{message}: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

bool CheckTriangle(int num1, int num2, int num3) // Метод проверки треугольника. От него нужно только да или нет
{
    bool flag = false;
    if (num1 < num2 + num3 & num2 < num1 + num3 & num3 < num1 + num2) flag = true;
    return flag;
}