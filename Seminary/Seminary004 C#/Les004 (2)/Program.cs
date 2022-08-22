// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!  Программа, которая принимает на вход число и выдаёт количество цифр в числе."
+ "\r\n\tПример\t456 -> 3\r\n\t\t78 -> 2\r\n\t\t89126 -> 5 ");

/*
 Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 
*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int num = Prompt("Введите число : ");



int NumberOfDigits(int num);
{
    int digitCount = 0;
    for (int i = num; i != 0; i /= 10)
    {
        digitCount++;
    }

    return digitCount;
}
System.Console.WriteLine(NumberOfDigits(num));

/* 2 способ через логарифм  */

int num2 = Prompt("Введите число : ");

Console.WriteLine((int)Math.Log10(num2) + 1);

/*
Все трёхзначные натуральные числа заключены в пределах от 100 (включительно) до 1000 (исключая последнее).
lg 100 = 2,  lg 1000 = 3.  Если  100  a < 1000,  то  lg 100  lg a < lg 1000,  т.е.  2  lg a < 3, а это значит, 
что логарифм трёхзначного числа начинается с двойки:  2,....
Вычислив целую часть логарифма трёхзначного числа и добавив к результату единицу, мы получим 3, то есть количество его цифр.
*/