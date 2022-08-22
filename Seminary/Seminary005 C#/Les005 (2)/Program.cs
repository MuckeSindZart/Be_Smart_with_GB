// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 1: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

*/
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    string printedArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) printedArray += $"{array[i]}, ";
        else printedArray += $"{array[i]}]";
    }
    Console.WriteLine(printedArray);
}

int[] InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] array = CreateArray(4, -8, 8);
PrintArray(array);
int[] newArray = InvertArray(array);
PrintArray(newArray);