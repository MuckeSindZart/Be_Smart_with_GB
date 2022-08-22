// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа которая, ищет разницу между максимальным и минимальным элементов заданного массива"
+ "\r\n\tПример\t [3, 7.3, 22.2, 2, 78] -> 76");

/*
Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7.3 22.2 2 78] -> 76
*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

double[] arrayFill(int size)
{
    int i = 0;
    double[] array = new double[size];

    while (i < size)
    {
        if (new Random().Next(0, 2) == 0) // или целое или дробное

        {
            array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 100), 1);
        }
        else
        {
            array[i] = new Random().Next(0, 100);
        }

        i++;
    }
    return array;
}


void printArray(double[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 4}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("] -> ");
}


double difference(double[] array)
{
    double minNum = array[0];
    double maxNum = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNum) { minNum = array[i]; }
        if (array[i] > maxNum) { maxNum = array[i]; }
    }
    return Math.Round(maxNum - minNum, 1); //   Math.Round(Number, 2) -->>  0.121565484 -->> 0.12
}


//----------------------------------------------------------------------//


int sizeArray = Prompt("Введите размер массива : ");
for (int i = 0; i < 4; i++) // чтобы не вызывать 4 раза Dotnet
{
    double[] newArray = arrayFill(sizeArray);
    printArray(newArray);
    System.Console.WriteLine($"{difference(newArray)}");
}
