// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
    Console.ForegroundColor = ConsoleColor.White;
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
    Console.ForegroundColor = ConsoleColor.White;
    int[,] array = new int[Prompt("Введите количество строк: "), Prompt("Введите количество колонок: ")];
    return array;
}


int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            newMatrix[i, j] = sum;
        }
    }
    return newMatrix;
}



//-------------------------------------------------------------------------------------------------//



Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Введите размер матрицы 1: ");
int[,] firstMatrix = Create2DArray();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Значения для матрицы 2: ");
Fill2DArray(firstMatrix);
Print2DArray(firstMatrix);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Введите размер матрицы 2: ");
int[,] secondMatrix = Create2DArray();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Значения для матрицы 2: ");
Fill2DArray(secondMatrix);
Print2DArray(secondMatrix);

if (
    firstMatrix.GetLength(0) == secondMatrix.GetLength(1) &&
    firstMatrix.GetLength(1) != secondMatrix.GetLength(0) ||
    firstMatrix.GetLength(0) != secondMatrix.GetLength(1) &&
    firstMatrix.GetLength(1) == secondMatrix.GetLength(0)
    )
{
    System.Console.WriteLine("Такие матрицы нельзя перемножать, количество столбцов матрицы А не равно количеству строк матрицы В");
}

else if (
    firstMatrix.GetLength(0) == secondMatrix.GetLength(1) &&
    firstMatrix.GetLength(0) >= secondMatrix.GetLength(0) &&
    firstMatrix.GetLength(1) <= secondMatrix.GetLength(1)
    )
{

    Console.WriteLine("Произведение матриц:");
    Print2DArray(MatrixMultiplication(firstMatrix, secondMatrix));
}

else if (
    firstMatrix.GetLength(0) == secondMatrix.GetLength(1) &&
    firstMatrix.GetLength(0) <= secondMatrix.GetLength(0) &&
    firstMatrix.GetLength(1) >= secondMatrix.GetLength(1)
    )
{

    Console.WriteLine("Произведение матриц:");
    Print2DArray(MatrixMultiplication(secondMatrix, firstMatrix));
}