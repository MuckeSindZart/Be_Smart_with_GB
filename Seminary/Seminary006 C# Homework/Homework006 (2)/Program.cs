// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; "
+ "\r\n\tПример:\tb1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)s");

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    double result = double.Parse(input);
    return result;
}

void SuppressionPointTwoLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (k1 == k2 && b1 == b2)
        {
            Console.WriteLine($"Прямые совпадают");
        }
        else
        {
            Console.WriteLine($"Прямые параллельны");
        }
    }
    else
    {
        double x = (-b2 + b1) / (-k1 + k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
}

//---------------------------------------------------------------------------//

double b1 = Prompt("Введите b1: ");

double k1 = Prompt("Введите k1: ");

double b2 = Prompt("Введите b2: ");

double k2 = Prompt("Введите k2: ");

SuppressionPointTwoLines(b1, k1, b2, k2);


