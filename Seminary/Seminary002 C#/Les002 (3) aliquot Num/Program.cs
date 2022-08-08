// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.");

/*
3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

*/

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num1 = Promt("Введите число 1 :");
int num2 = Promt("Введите число 2 :");

if (num1 % num2 == 0)
{ System.Console.WriteLine($"Число {num1} кратно {num2} "); }
else
{ System.Console.WriteLine($"Число {num1} не кратно {num2}, остаток {num1 % num2}"); }