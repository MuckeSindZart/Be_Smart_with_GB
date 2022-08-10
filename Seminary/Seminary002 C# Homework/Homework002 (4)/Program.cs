// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

/*
Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
start:
Console.ForegroundColor = ConsoleColor.White;

int day = Prompt("Введите день недели :");

if (day > 7 || day <= 0)  // fix ( || day <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("Такого дня недели не бывает");
    goto start;
}
else if (day % 7 == 0 || day % 6 == 0)
{
    System.Console.WriteLine($"{day}->да");
}
else
{
    System.Console.WriteLine($"{day}->нет");
}