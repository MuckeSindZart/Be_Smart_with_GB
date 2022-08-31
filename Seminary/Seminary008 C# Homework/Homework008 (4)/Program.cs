// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 4. Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("| ");
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            System.Console.Write(" {0, 4}" , array[i, j] + ",");
        }
        System.Console.WriteLine(" {0, 4}" ,array[i, array.GetLength(1) - 1] + "|");
        System.Console.WriteLine();
    }

    Console.ForegroundColor = ConsoleColor.White;
    System.Console.WriteLine();

}


int[,] Fill2DArraySpiral(int[,] array)
{

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = num;

        num++;

        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= array.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > array.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    return array;
}


int[,] Create2DArray()
{
    Console.ForegroundColor = ConsoleColor.White;
    int size = Prompt("Введите размер спирали : ");
    int[,] array = new int[size, size];
    return array;
}



//------------------------------------------------//

int[,] takeArray = Create2DArray();
Print2DArray(takeArray);
Fill2DArraySpiral(takeArray);
Print2DArray(takeArray);