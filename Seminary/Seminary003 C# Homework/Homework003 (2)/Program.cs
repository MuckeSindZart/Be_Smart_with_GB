// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
System.Console.WriteLine("P.S. \t A (3,6,8); B (2,1,-7), -> 15.84;\r\n \t A (7,-5, 0); B (1,-1,9) -> 11.53;");


/*
Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
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
int aZ = Prompt("Введите b Z : ");
int bX = Prompt("Введите b X : ");
int bY = Prompt("Введите b Y : ");
int bZ = Prompt("Введите b Z : ");

double result = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY)+ (aZ - bZ) * (aZ - bZ));
System.Console.WriteLine($"A ({aX},{aY},{aZ}); B ({bX},{bY},{bZ}),->{Math.Round(result, 2)}");
System.Console.WriteLine("Растояние между этими двумя точками =" + result);