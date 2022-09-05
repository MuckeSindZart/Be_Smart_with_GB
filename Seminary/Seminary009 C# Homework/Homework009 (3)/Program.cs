// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }

    return Ackermann(m - 1, Ackermann(m, n - 1));
}


//-------------------------------------------------------//

int m = Prompt("m = ");

int n = Prompt("n = ");

int answer = Ackermann(m, n);


System.Console.WriteLine($"A({m}, {n}) = {answer}");
