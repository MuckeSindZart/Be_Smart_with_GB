// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А."
+ "\r\n\tПример:\t 7 -> 28 \r\n\t\t 4 -> 10 \r\n\t\t 8 -> 36");
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


int GetSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int GetSumFast(int a)
{
    return a * (a + 1) / 2;
}

//-------------------------------------//

int num = Prompt("Введите число : ");
System.Console.WriteLine($"{num} -> {GetSum(num)}");

Console.WriteLine($"{num} -> {GetSumFast(num)}");




