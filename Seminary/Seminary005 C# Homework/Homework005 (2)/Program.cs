// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа которая, показывает сумму элементов, стоящих на нечётных позициях." +
                "\r\n\tПример:\t[3, 7, 23, 12] -> 19 \r\n\t\t[-4, -6, 89, 6] -> 0");

/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
        array[i] = new Random().Next(-100, 100);
        i++;
    }
    return array;
}


void printArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("{0, 3}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсоты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("] -> ");
}



int evenIndexNumSum(int[] array)   // 1,3,5,7,9... нечетные
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

//----------------------------------------------------------------------//

int sizeArray = Prompt("Введите размер массива : ");
for (int i = 0; i < 4; i++) // чтобы не вызывать 4 раза Dotnet
{
    int[] newArray = arrayFill(sizeArray);
    printArray(newArray);
    System.Console.WriteLine(evenIndexNumSum(newArray));
}