// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
4.1. Напишите программу, которая генерирует несколько случайных чисел,
 и в цикле проверяет, кратны ли эти числа предварительно введенному числу,
 при кратности - цикл прерывается.
Введенное число 2
13 -> нет 
15 -> нет 
12 -> да
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int input = Prompt("Введите число : ");
int randNum = new Random().Next(20);
int i = 0;
while (i == 0)
{
    if (randNum % input != 0)
    {
        System.Console.WriteLine(randNum + "-> нет");
        randNum = new Random().Next(20);
    }
    else
    {
        { System.Console.WriteLine(randNum + "-> да"); }
        i = 1;
    }
}
System.Console.WriteLine();