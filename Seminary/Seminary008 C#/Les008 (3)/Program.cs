// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
{ 1, 9, 9, 0, 2, 8, 0, 9 } 
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


void GetFreqOfMatrixElements(int[,] array)
{
    int[] count = new int[10];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            count[array[i,j]]++;
        }
    }
    for (int i = 0; i < count.Length; i++){
        System.Console.WriteLine($"Число {i} встретилось {count[i]} раз(а)");
    }
}


//--------------------------------------------------------//

int[,] array = Create2DArray();
Print2DArray(array);
Fill2DArray(array);
Print2DArray(array);

GetFreqOfMatrixElements(array);