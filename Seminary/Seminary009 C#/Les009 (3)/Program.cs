// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int CalculateSummary(int number)
{
   
    if (number == 0)
    {
        return 0;
    }
    
    return CalculateSummary(number/10) + number % 10;
    System.Console.WriteLine("tik");

}

int number = Prompt("Input : ");
System.Console.WriteLine(CalculateSummary(number));