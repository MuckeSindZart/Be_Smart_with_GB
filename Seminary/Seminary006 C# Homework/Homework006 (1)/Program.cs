// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]},");
    }
    System.Console.Write($"{array[array.Length - 1]}] ");

}

int[] CreateArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt("Введите следующее число : "); ;
    }
    return array;
}

int AboveZeroCount(int number, int countAboveZero)
{
    if (number > 0)
    {
        countAboveZero++;
    }
    return countAboveZero;
}


int AboveZeroInArray(int[] array)
{
    int answer = 0;
    for (int i = 0; i < array.Length; i++)
    {
        answer = AboveZeroCount(array[i], answer);
    }
    return answer;
}

//--------------------------------------------------//

int[] newArray = CreateArray(Prompt("Введите размер массива : "));
PrintArray(newArray);
System.Console.WriteLine($"-> {AboveZeroInArray(newArray)}");