// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");


/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/



int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

/*
int PoliNum(int number)
{
    int halfNumber1 = number / 1000;
    int halfNumber2 = (number % 10) * 10 + (number / 10) % 10;

    int result = -1;
    if (halfNumber1 == halfNumber2) { result = 1; }
    return result;
}
*/


bool PoliNum(int number)        // Fix
{
    int halfNumber1 = number / 1000;
    int halfNumber2 = (number % 10) * 10 + (number / 10) % 10;

    return (halfNumber1 == halfNumber2);
}


start:
int num = Prompt("Введите число пятизначное число : ");

if (num < 10000 || num > 99999)
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("Ошибка, число не пятизначное");
    goto start;
}



if (PoliNum(num) == true)
{
    System.Console.WriteLine($"{num}->да");
}

else
{
    System.Console.WriteLine($"{num}->Нет");
}



