﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
/* Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num1 = Promt("Введите число : ");

for (int i = 2; i <= num1; i=i+2)

   // if (i % 2 == 0) //Лишнее условие
    {
        System.Console.Write(i+" ");
    }
System.Console.WriteLine();    