// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины."
                + "\r\n\tP.S.\t Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.");

/*
Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


bool CheckTriangleSides(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

void IsTriangle()
{
    int[] triangle = new int[3];
    for (int i = 0; i < 3; i++)
    {

        triangle[i] = Prompt($"Введите длину {i + 1}-й стороны: ");
    }

    if (CheckTriangleSides(triangle[0], triangle[1], triangle[2]))
    {
        System.Console.WriteLine($"Треугольник с длинами сторон {triangle[0]}, {triangle[1]} и {triangle[2]} существует.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;

        System.Console.WriteLine($"Треугольник с длинами сторон {triangle[0]}, {triangle[1]} и {triangle[2]} НЕ существует!");
    }
}



IsTriangle();
