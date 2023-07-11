// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел Вы хотите ввести: ");
string? M = Console.ReadLine();

Console.WriteLine("Введите числа: ");
string? numbers = Console.ReadLine();

string[] separators = { ",", ";", ", ", "; ", " ", "  " };

string[] myArray = numbers.Split(separators, Convert.ToInt32(M), StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Массив: [{String.Join(";", myArray)}]");

double[] ConvertStringToNumbers(string[] array)
{
    double[] newArray = new double[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if(double.TryParse(array[i], out double result)) newArray[i] = result;
    }
    return newArray;
}

int CountPositiveNumbers(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

double[] covertedArray = ConvertStringToNumbers(myArray);
Console.WriteLine($"Новый массив: [{String.Join(";", covertedArray)}]");
Console.WriteLine($"Введено чисел больше нуля: {CountPositiveNumbers(covertedArray)}");
