// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая перевернёт одномерный массив "
+ "\r\n\tПример\t[1 2 3 4 5] -> [5 4 3 2 1]\r\n\t\t[6 7 3 6] -> [6 3 7 6]");


/*
Задача 1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

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
        array[i] = new Random().Next(0, 11);
        i++;
    }
    return array;
}


void printArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 1}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("]");
}

int[] reversArray(int[] array)
{
    int swap = 0;
    for (int i = 0; i < array.Length/2 ; i++)
    {
        swap = array[i];
        array[i] = array[(array.Length-1) - i];
        array[(array.Length-1) - i] = swap;
    }
    return array;
}
//------------------------------------------------------------------//

int sizeArray = Prompt("Введите размер массива : ");

int[] newArray = arrayFill(sizeArray);
printArray(newArray);

System.Console.Write(" -> ");

int[] reverArray = reversArray(newArray);
printArray(reverArray);