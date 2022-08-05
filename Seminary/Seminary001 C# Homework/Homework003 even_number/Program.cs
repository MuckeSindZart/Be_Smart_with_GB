// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! программа, которая на вход принимает число и выдаёт,является ли число чётным");

/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int num1 = Promt("Введите число : ");

if (num1%2==0) {System.Console.WriteLine($"Число <{num1}> четное");}
else {System.Console.WriteLine($"Число <{num1}> не четное");}