// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10

*/



int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


void MakeBinary(int num)
{
    
    string binary = string.Empty;
    int n = num;
    while (n > 0)
    {
        binary = $"{n % 2}" + binary;
        n /= 2;
    }

    Console.WriteLine($"{num} -> {binary}");
}


int number = Prompt("Введите число : ");
MakeBinary(number);