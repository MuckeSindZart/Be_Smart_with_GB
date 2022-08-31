// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        System.Console.Write("|");
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            System.Console.Write($"{array[i, j]:f1}\t");
        }
        System.Console.WriteLine($"{array[i, array.GetLength(1) - 1]:f1}|");
    }

    Console.ForegroundColor = ConsoleColor.White;
    System.Console.WriteLine();

}


double[,] Fill2DArray(double[,] array)
{
  int from = -10;
    int before = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            if (new Random().Next(0, 2) == 0) // или целое или дробное

            {
                array[i, j] = new Random().NextDouble() * new Random().Next(from, before);
            }
            else
            {
                array[i, j] = new Random().Next(from, before);
            }

        }
       
    }return array;
}


double[,] Create2DArray()
{
    double[,] array = new double[Prompt("Введите количество строк: "), Prompt("Введите количество колонок: ")];
    return array;
}



//--------------------------------------------------------------//



double[,] takeArray = Create2DArray();
Print2DArray(takeArray);
Fill2DArray(takeArray);
Print2DArray(takeArray);