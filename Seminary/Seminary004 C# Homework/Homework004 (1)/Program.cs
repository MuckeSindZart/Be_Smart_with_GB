// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int expon(int A, int B)
{
    int exp = A;
    for (int i = 1; i < B; i++)
    {
        A = A * exp;
    }
    return A;
}


//-------------------------------------//

int A = Prompt("Введите число : ");
int B = Prompt("Введите число : ");
int result = expon(A, B);
System.Console.WriteLine($"{A}в натуральную степени {B} = {result}");
