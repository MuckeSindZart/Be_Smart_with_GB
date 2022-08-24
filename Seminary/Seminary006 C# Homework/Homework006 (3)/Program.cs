// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа генерирует двумерный массив со случайными числами и выводит его на экран. ");
/* 
Задача 3. Со Звездочкой (*). Сгенерировать двумерный массив со случайными числами,
 вывести его на экран, оформить в виде функций (пригодится в дальнейшем)
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
            System.Console.Write($"{array[i, j]},");
        }
        System.Console.WriteLine($"{array[i, array.GetLength(1) - 1]} |");
    }
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
    int[,] array = new int[Prompt("Введите количество колонок: "), Prompt("Введите количество строк: ")];
    return array;
}

//--------------------------------------------------------------//



int[,] takeArray = Create2DArray();
Print2DArray(takeArray);
Fill2DArray(takeArray);
Print2DArray(takeArray);