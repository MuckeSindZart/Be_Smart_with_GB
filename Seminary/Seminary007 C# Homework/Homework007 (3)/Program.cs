// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{Math.Round(array[i], 1)};\t");
    }
}


void Print2DArray(int[,] array)
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
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine($"{array[i, array.GetLength(1) - 1]}|");
    }

    Console.ForegroundColor = ConsoleColor.White;
    System.Console.WriteLine();

}


int[,] Fill2DArray(int[,] array)
{
    int from = Prompt("Заполнить случайными значениями от: ");
    int before = Prompt("Заполнить случайными значениями до: ");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, before);
        }
    }
    return array;
}


int[,] Create2DArray()
{
    int[,] array = new int[Prompt("Введите количество строк: "), Prompt("Введите количество колонок: ")];
    return array;
}


double[] CalcAverageColIn2DArray(int[,] array)

{

    double[] averageArray = new double[array.GetLength(1)];
    double sumNum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumNum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumNum += array[j, i];
        }
        averageArray[i] = sumNum / array.GetLength(0);
    }
    return averageArray;
}



//--------------------------------------------------------------//



int[,] takeArray = Create2DArray();
Print2DArray(takeArray);
Fill2DArray(takeArray);
Print2DArray(takeArray);


System.Console.WriteLine("среднее арифметическое элементов в каждом столбце ");
PrintArray(CalcAverageColIn2DArray(takeArray));