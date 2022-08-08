// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.");


/*
2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/

int randomNum = new Random().Next(10,99);

int a = randomNum%10;
int b = randomNum/10;
System.Console.WriteLine(randomNum);

if (a>b) {System.Console.WriteLine($"max={a}, min={b}");}
else {System.Console.WriteLine($"max={b}, min={a}");}
