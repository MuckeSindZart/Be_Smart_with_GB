// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4

*/

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
Например, задан массив:
1   4   7
5   9   2
8   4   2
Сумма элементов главной диагонали: 1+9+2 = 12

*/

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
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

void LookingIn2DArray(int[,] array)
{
    int findNum = Prompt("Какое число ищем? : ");
    int answer = 0;
    bool stop = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (findNum == array[i, j])
            {
                System.Console.WriteLine($"{findNum} в строке {i+1} столбце {j+1}");
                stop=true;
            }
            if(stop==true){break;}
        }
        if(stop==true){break;}
    }
    
}

//--------------------------------------------------------------//



int[,] takeArray = Create2DArray();
Print2DArray(takeArray);
Fill2DArray(takeArray);
Print2DArray(takeArray);
LookingIn2DArray(takeArray);