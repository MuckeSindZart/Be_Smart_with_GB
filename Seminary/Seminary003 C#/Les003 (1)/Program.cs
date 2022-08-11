// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.");

/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int printXY(float x, float y)
{
    System.Console.Write($"X={x},Y={y} ");
    
    if (x > 0 && y > 0) { return 1; }

    else if (x < 0 && y > 0) { return 2; }

    else if (x < 0 && y < 0) { return 3; }

    else if (x > 0 && y < 0) { return 4; }

    else { return -1; }
}

void printSetXY(int num)
{
    if (num == 1)
    {
        Console.WriteLine("Плоскость - 1");
        System.Console.WriteLine("X > 0, Y > 0");
    }
    if (num == 2)
    {
        Console.WriteLine("Плоскость - 2");
        System.Console.WriteLine("X < 0, Y > 0");
    }
    if (num == 3)
    {
        Console.WriteLine("Плоскость - 3");
        System.Console.WriteLine("X < 0, Y < 0");
    }
    if (num == 4)
    {
        Console.WriteLine("Плоскость - 4");
        System.Console.WriteLine("X > 0, Y < 0");
    }
    if (num == -1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка кординат!");
    }
}



start:

Console.ForegroundColor = ConsoleColor.White;
int result = printXY(Prompt("Введите X :"), Prompt("Введите Y :"));

if (result < 0) { goto start; }

printSetXY(result);

System.Console.WriteLine();




