// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int SumNumbersBetween(int start, int end)
{
    if (start == end)
    {
        return end;
    }

    return start + SumNumbersBetween(start + 1, end);
}


//---------------------------------------------------//

int m = Prompt("Введите первое число (M): ");

int n = Prompt("Введите второе число (N): ");

int answer = SumNumbersBetween(m, n);

Console.WriteLine($"Сумма чисел от {m} до {n} равна {answer}");
