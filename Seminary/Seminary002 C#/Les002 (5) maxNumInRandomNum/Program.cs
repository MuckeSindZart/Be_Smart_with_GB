// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.");

/*
2.1. Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
7812 -> 8 
1213-> 3 
845 -> 8
*/

int randNum = new Random().Next(10, 9999);
System.Console.WriteLine("Число " + randNum);
int max = 0;
while (randNum>0)
{
    int a = randNum%10;
    if (max<a){max=a;}
    randNum = randNum/10;
}

System.Console.WriteLine("max="+max);

