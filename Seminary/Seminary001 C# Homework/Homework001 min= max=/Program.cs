// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7, min = 5
a = -9 b = -3 -> max = -3, min = -9
*/

System.Console.Write("Введите число 1 : ");
string inp1 = System.Console.ReadLine();
int num1 = int.Parse(inp1);

System.Console.Write("Введите число 2 : ");
string inp2 = System.Console.ReadLine();
int num2 = int.Parse(inp2);

if (num1 == num2)
{
    System.Console.Write("Число " + inp1 + " равно числу " + inp2);
    }

else if (num1 > num2)
{
    System.Console.Write("max = " + inp1 + ", min = " + inp2);
    }

else 
{
    System.Console.Write("max = " + inp2 + ", min = " + inp1);
    }

System.Console.WriteLine();