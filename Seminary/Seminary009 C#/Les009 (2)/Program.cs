// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void ShowNumberRow(int mNumber, int nNumber)
{
if (mNumber>=nNumber){
    return;
}
ShowNumberRow(mNumber,nNumber-1);
System.Console.WriteLine($"{nNumber}");


}


ShowNumberRow(Prompt("Input : "),Prompt("Input : "));