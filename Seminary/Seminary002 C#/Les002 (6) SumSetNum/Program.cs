// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.");
/*
3.1. Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int[] inputArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    { array[i] = Prompt("Введите " + i + " элемент массива : "); }
    return array;

}

int Summ(int[] array)
{
    int summ = 0; for (int i = 0; i < array.Length; i++)
    { summ = summ + array[i]; }
    return summ;
}

int arraySize = Prompt("Введите размер массива : ");
int[] array = inputArray(arraySize);
int summ = Summ(array);
double average = summ / ((double)array.Length);

System.Console.WriteLine("Сумма " + summ);
System.Console.WriteLine("Среднее значение " + average);







