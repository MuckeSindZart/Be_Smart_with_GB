// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
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
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        System.Console.Write("| ");
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            System.Console.Write($"{array[i, j]},");
        }
        System.Console.WriteLine($"{array[i, array.GetLength(1) - 1]} |");
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


void FindMinElement(int[,] matrix, ref int indexI, ref int indexJ)
{
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
}


int[,] DeleteRowAndColumnByIndexes(int[,] array, int indexI, int indexJ)
{
    int[,] newMatrix = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        column = 0;
        if (i != indexI)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != indexJ)
                {
                    newMatrix[row, column] = array[i, j];
                    column++;
                }
            }
            row++;
        }
    }
    return newMatrix;
}

//----------------------------------------------------//

int[,] array = Create2DArray();
Print2DArray(array);
Fill2DArray(array);
Print2DArray(array);

int minI = 0;
int minJ = 0;
FindMinElement(array, ref minI, ref minJ);
Print2DArray(DeleteRowAndColumnByIndexes(array, minI, minJ));