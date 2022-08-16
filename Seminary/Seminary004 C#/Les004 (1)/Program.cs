// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.");
/*
Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int SetN(int num)
{
    if (num == 0 || num < 0)    // проверка
    {
        Console.ForegroundColor = ConsoleColor.Red;

        System.Console.Write($"Ошибка, число {num}<||=0");
    }
    
    int fact = 1;

    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;

    }
return fact;
}

int num = Prompt("Введите число : ");
System.Console.WriteLine(SetN(num));


