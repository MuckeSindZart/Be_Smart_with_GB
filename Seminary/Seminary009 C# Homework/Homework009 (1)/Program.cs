// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.");
/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


void PrintNumbersBetween(int start, int end) 
{
    if (start <= end)
    {
        System.Console.Write($"{start}");

        if (start < end)
        {
            System.Console.Write(", ");
            PrintNumbersBetween(start + 1, end);
        }
    }
}


//------------------------------------------------------//

int m = Prompt("Введите первое число (M): ");

int n = Prompt("Введите второе число (N): ");

System.Console.WriteLine($"Числа от {m} до {n}: ");

PrintNumbersBetween(m, n);
