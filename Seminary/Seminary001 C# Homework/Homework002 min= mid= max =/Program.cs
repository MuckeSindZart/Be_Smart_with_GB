// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int swap = 0;

int num1 = Promt("Введите число 1 : ");
int num2 = Promt("Введите число 2 : ");
int num3 = Promt("Введите число 3 : ");


int max = num1;
int mid = num2;
int min = num3;
if (max < num2) { mid = max; max = num2; }
if (max < num3) {min = mid; mid = max; max = num3; }
if (mid < min)  {swap = mid; mid = min; min = swap;}

System.Console.WriteLine($"min={min} mid={mid} max={max}");
System.Console.WriteLine($"{num1} {num2} {num3} -> {max} ");