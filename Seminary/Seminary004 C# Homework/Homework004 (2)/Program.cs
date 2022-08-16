// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");

/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12


*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int SumOfNumber(int a)
{

    int size = 0;
    int i = 10;
    int result = (a % i);

    while (a != 0)
    {
        i = i * 10;
        result= result + (a % i)/(i/10);
        a = a - a % i;
        size++;


    }
    // return size;
    return result;
}
//-------------------------//


int inputNum = Prompt("Введите число : ");

System.Console.WriteLine($"size {SumOfNumber(inputNum)}");


