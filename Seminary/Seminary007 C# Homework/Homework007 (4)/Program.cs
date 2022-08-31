// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их.
Затем найдите минимальное значение по каждой колонке, тоже ссумируйте их. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
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


int CalcSumMaxNumInRow(int[,] array)
{
    int sumMaxNum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxNum = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maxNum)
            {
                maxNum = array[i, j];
            }
        }
        System.Console.WriteLine($"{i + 1}:Row sumMaxNumInRow={sumMaxNum}+{maxNum}={sumMaxNum + maxNum}"); //Что бы при проверке не считать самому
        sumMaxNum += maxNum;
    }
    return sumMaxNum;
}


int CalcSumMinNumInCol(int[,] array)
{
    int sumMinNum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int minNum = array[0, i];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[j, i] < minNum)
            {
                minNum = array[j, i];
            }
        }
        System.Console.WriteLine($"{i + 1}:Col sumMinNumInCol={sumMinNum}+{minNum}={sumMinNum + minNum} "); //Что бы при проверке не считать самому
        sumMinNum += minNum;
    }
    return sumMinNum;
}



//--------------------------------------------------------------//



int[,] takeArray = Create2DArray();
Print2DArray(takeArray);
Fill2DArray(takeArray);
Print2DArray(takeArray);
int answer = CalcSumMaxNumInRow(takeArray) - CalcSumMinNumInCol(takeArray);
System.Console.WriteLine($"Сумма Максимальных чисел в строке минус, Сумма Минимальных чисел в колонке = {answer}");