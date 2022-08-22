// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

string ArrayToString(int[] array)
{
    string stringArray = string.Empty;

    for (int i = 0; i < array.Length-1; i++)
    {
            stringArray += $"{array[i]} ";
        
    }
            stringArray += $"{array[array.Length-1]}";
     

    return stringArray;
}

int[] Fibonacci(int n)
{
    int[] fib = new int[n];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < fib.Length; i++)
    {
        fib[i] = fib[i - 2] + fib[i - 1];
    }
    return fib;
}

void PrintResult(int n)
{
    Console.WriteLine($"Если N = {n} -> {ArrayToString(Fibonacci(n))}");
}

PrintResult(5);
PrintResult(3);
PrintResult(7);

