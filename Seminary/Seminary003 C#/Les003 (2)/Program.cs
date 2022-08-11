// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.");
System.Console.WriteLine("A (3,6); B (2,1) -> 5,09      A (7,-5); B (1,-1) -> 7,21");

/*
Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int aX = Prompt("Введите a X : ");
int aY = Prompt("Введите a Y : ");
int bX = Prompt("Введите b X : ");
int bY = Prompt("Введите b Y : ");

double result = Math.Sqrt((aX-bX)*(aX-bX)+(aY-bY)*(aY-bY));
System.Console.WriteLine("Растояние между этими двумя точками ="+result);
