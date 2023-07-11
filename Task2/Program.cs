// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1 * x + b1 = k2 * x + b2 => x = (b2 - b1) / (k1 - k2)

Console.WriteLine("Введите значение для b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение для k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

void ValidateLines()
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (b1 == b2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        Console.WriteLine($"Координаты точки пересечения двух прямых: x = {x}, y = {y}");
    }
}

ValidateLines();