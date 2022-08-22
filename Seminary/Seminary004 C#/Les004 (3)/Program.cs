// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N."
+ "\r\n\tПример:\t4 -> 24 \r\n\t\t5 -> 120 ");

/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */




int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int Factorial(int num)
{
    int answer = 1;
    for (int i = 2; i <= num; i++)
    {
        answer *= i;
    }
    return answer;
}

int num=Prompt("Введите число : ");
System.Console.WriteLine($"\t\t{num} -> {Factorial(num)}");