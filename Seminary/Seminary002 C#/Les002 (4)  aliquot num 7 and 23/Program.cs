// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");

/*
4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да

*/

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num1 = Promt("Введите число : ");

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    System.Console.WriteLine($"Число {num1} кратно 7 и 23");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    if (num1 % 7 == 0) { System.Console.WriteLine($"Число {num1} кратно 7 но не кратно 23"); }
    if (num1 % 23 == 0) { System.Console.WriteLine($"Число {num1} кратно 23 но не кратно 7"); }
}