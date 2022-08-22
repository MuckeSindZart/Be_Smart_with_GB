// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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
    System.Console.Write("\t\t [");

    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] +","); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        
    }

    System.Console.WriteLine($"{array[array.Length-1]}]");
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}

int[] array = CreateArray(12, -9, 9);
PrintArray(array);
Console.WriteLine($"Сумма положительных чисел равна {FindPositiveSum(array)}.");
Console.WriteLine($"Сумма отрицательных чисел равна {FindNegativeSum(array)}.");