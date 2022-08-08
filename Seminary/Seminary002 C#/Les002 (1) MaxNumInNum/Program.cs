// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
/*
1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num = Promt("Введите число : ");

if (num > 99 && num < 1000)
{
    System.Console.WriteLine(num % 10);
}
else { System.Console.WriteLine($"Ошибка, число {num} не трёхзначное"); }