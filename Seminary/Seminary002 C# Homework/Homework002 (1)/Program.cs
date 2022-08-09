// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

/*
 Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

start:
Console.ForegroundColor = ConsoleColor.White;
int a = Prompt("Введите трёхзначное число : ");

if (a > 99 && a < 1000)
{
    int result = (a % 100 - a % 10) / 10;
    System.Console.WriteLine(a + "->" + result);
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Ошибка, число {a} не трёхзначное!");
    goto start;
}

