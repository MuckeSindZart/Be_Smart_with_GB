// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
4.1. Напишите программу, которая генерирует несколько случайных чисел,
 и в цикле проверяет, кратны ли эти числа предварительно введенному числу,
 при кратности - цикл прерывается.
Введенное число 2
13 -> нет 
15 -> нет 
12 -> да
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void FillArray(int[] collection)
{
    int leng = collection.Length;
    int i = 0;
    while (i < leng)
    {
        collection[i] = new Random().Next(1, 100);
        i++;
    }
}

int input = Prompt("Введите число : ");

// из 20 случайных чисел массива
int[] randNumArray = new int[20];
FillArray(randNumArray);


for (int i = 0; i<randNumArray.Length; i++)
{
    if (randNumArray[i] % input != 0 )
    {
        System.Console.WriteLine(randNumArray[i] + "-> нет");
    }

    else 
    {
        { System.Console.WriteLine(randNumArray[i] + "-> да"); }
        
        break;
    }
}
/* 
//пока не выпадет кратное случайное число
int i = 0;
int randNum = new Random().Next(1,20);
while (i == 0)
{
    if (randNum % input != 0 )
    {
        System.Console.WriteLine(randNum + "-> нет");
        randNum = new Random().Next(1,20);
    }

    else 
    {
        { System.Console.WriteLine(randNum + "-> да"); }
        i = 1;
    }
}
*/
System.Console.WriteLine();