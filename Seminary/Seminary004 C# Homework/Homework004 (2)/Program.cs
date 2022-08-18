// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход число и выдаёт сумму цифр в числе."
                + "\r\n452 -> 11;\r\n82 -> 10;\r\n9012 -> 12;");

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


int SumOfNumber(int num)
{
    int result = 0;

    while (num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }

    return result;
}

//---------------------------------------//


int inputNum = Prompt("Введите число : ");

System.Console.WriteLine($"{inputNum} -> {SumOfNumber(inputNum)}");
System.Console.WriteLine();

