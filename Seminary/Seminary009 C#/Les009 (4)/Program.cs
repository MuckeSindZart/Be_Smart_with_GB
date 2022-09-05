// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

*/


int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int CalculateSame(int number, int number2)
{
   
    if ( number2==0)
    {
        return 1;
    }
    
return number*CalculateSame(number,number2-1);
}


System.Console.WriteLine(CalculateSame(Prompt("Input : "),Prompt("Input : ")));