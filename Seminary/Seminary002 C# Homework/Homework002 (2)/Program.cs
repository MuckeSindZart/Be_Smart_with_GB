// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");

/*
Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int i = 0;

while (i < 3)
{
    int a = new Random().Next(100, 1000);
    int result = ((a / 100) * 10 + a % 10);
    System.Console.WriteLine(a + "->" + result);
    i++;
}

System.Console.WriteLine();