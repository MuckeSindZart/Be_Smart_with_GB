// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 6: Проверка на простое число: 
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

bool CalculateSame(int number, int divider)
{

    if (divider == 1)
    {
        return true;
    }

    return CalculateSame(number, divider - 1) && (number % divider > 0);
}

int number = Prompt("Input");
System.Console.WriteLine(CalculateSame(number, number-1));