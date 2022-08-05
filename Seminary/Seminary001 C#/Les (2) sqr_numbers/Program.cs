/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да 
a = 2 b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3 b = 9 -> да
*/

Console.WriteLine("Hello, World!");

System.Console.WriteLine("Введите значение 1");
string NumA = System.Console.ReadLine();
int a = int.Parse(NumA);
System.Console.WriteLine("Введите значение 2");
string NumB = System.Console.ReadLine();
int b = int.Parse(NumB);

 if (a*a == b)
 {
     System.Console.WriteLine($"a {a}^2 = {b} -> Да");
     }
 else
 {
     System.Console.WriteLine($"Не верно {a}^2 != {b} -> Нет");
    }