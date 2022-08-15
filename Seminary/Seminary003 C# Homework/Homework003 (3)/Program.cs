// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
System.Console.WriteLine("P.S. \t 3 -> 1, 8, 27; \r\n \t 5 -> 1, 8, 27, 64, 125;");


/*
Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void SetN(int num) //выдаёт таблицу кубов чисел
{
    if (num == 0 || num < 0)    // проверка
    {
            Console.ForegroundColor = ConsoleColor.Red;

        System.Console.Write($"Ошибка, число {num}<||=0");
    }
    else
    {
        System.Console.Write($"{num} -> ");
    }




    for (int i = 1; i <= num; i++) //таблица
    {
        System.Console.Write(i * i * i);


        if (i < num)
        {
            System.Console.Write(", ");
        }
    }

    System.Console.WriteLine(";");
}


SetN(Prompt("Введите число : "));