// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке."
                +"\r\n\tПример:\t [1,0,1,1,0,1,0,0]");

/* 
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] 
*/


int [] GetArrayRandom (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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


int[] newArray = GetArrayRandom(8);
PrintArray(newArray);