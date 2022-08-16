// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)");

/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
 И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19
*/

int[] arrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(-100, 101);
        i++;
    }
    return array;
}


void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }

}

void Max(int[] array)
{
    int maxNum = array[0];
    int nextMaxNum = array[1];
    int swap = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            swap = maxNum;
            maxNum = array[i];
            nextMaxNum = swap;
        }
        else if (array[i] > nextMaxNum) 
        {
            nextMaxNum = array[i]; 
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Max={maxNum}");
    System.Console.WriteLine($"NextMax={nextMaxNum}");

}


int[] result = arrayFill(5);
printArray(result);

Max(result);
