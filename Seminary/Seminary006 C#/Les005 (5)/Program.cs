// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}


int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}


void printArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) { System.Console.Write(" "); }
        System.Console.Write("{0, 1}", array[i] + ", "); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсоты)
    }

    System.Console.WriteLine($" {array[array.Length - 1]}]");
}

int[] array1 = CreateArray(5, 0, 10);
System.Console.Write("array1->");
printArray(array1);
int[] array2 = CopyArray(array1);
System.Console.Write("array1->");

array1[1] = -1;
printArray(array1);
System.Console.WriteLine("change array1, but not array2");

System.Console.Write("array2->");
printArray(array2);




