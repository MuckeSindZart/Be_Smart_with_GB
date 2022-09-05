// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 5: Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки”
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int CalculateSame(int number)
{

    if (number <= 1)
    {
        return number;
    }

    return CalculateSame(number % 2);
}


if (CalculateSame(Prompt("Input : ")) == 0)
{
    System.Console.WriteLine($"Является степень двойки");
}
else
{
    System.Console.WriteLine($"Не является степенью двойки");

}