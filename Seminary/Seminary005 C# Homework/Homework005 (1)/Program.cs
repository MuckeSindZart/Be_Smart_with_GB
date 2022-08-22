// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2");
System.Console.WriteLine();
/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int[] arrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(99, 1000);
        i++;
    }
    return array;
}


void printArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("]");

}


int evenNumberCounter(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) { evenCount++; };
    }
    return evenCount;
}


//----------------------------------------------------------------------//

int sizeArray = Prompt("Введите размер массива : ");
for (int i = 0; i < 4; i++) // чтобы не вызывать 4 раза Dotnet
{
    int[] newArray = arrayFill(sizeArray);
    printArray(newArray);
    System.Console.Write(" -> ");
    System.Console.WriteLine(evenNumberCounter(newArray));
}