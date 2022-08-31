// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
    int from = 0;
    int before = 31;

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


int LookingIn2DArray(int row, int col, int[,] array)
{
    int answer = 0;
    if (row < 0 || col < 0)
    {
        System.Console.WriteLine("Позиция не может быть меньше или равна 0");
        return answer;
    }
    else if (row <= array.GetLength(0) - 1 && col <= array.GetLength(1) - 1)
    {
        System.Console.WriteLine($"В строке {row} столбце {col} записано {array[row - 1, col - 1]}");
        answer = array[row - 1, col - 1];
    }
    else
    {
        System.Console.WriteLine($"В массиве нет строки {row} столбца {col}");
    }
    return answer;
}



//--------------------------------------------------------------//



int[,] takeArray = Create2DArray();
Print2DArray(takeArray);
Fill2DArray(takeArray);
Print2DArray(takeArray);

int searchRow = Prompt("В строке: ");
int searchCol = Prompt("В столбце: ");
int Value = LookingIn2DArray(searchRow, searchCol, takeArray);
