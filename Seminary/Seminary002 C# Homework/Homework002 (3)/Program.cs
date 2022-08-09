// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

/*
Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


//сколько цифр в числе 
int SizeOfNumber(int a)
{
    int size = 1;
    int i = 9;

    //если - поменять знак на +
    if (a < 0) { a = -a; }

    // если >= 99 size++
    while (a > i)

    {
        i = i * 10 + 9;
        size++;
    }
    return size;

}
/*
//сколько цифр в числе вариант 2
int sizeOfNumber(int a)                                  
{
int size = 0;
int i = 1;
if (a < 0) { a = -a; }
while (a != 0)
{
i = i * 10;
a = a - a % i;
size++;
}
if (a >= 0 && size == 0) { size = 1; }
return size;
}*/

//заполнить массив с конца 
int[] FillArray(int number, int size)
{
    int[] array = new int[size];
    while (size > 0)
    {
        array[size - 1] = number % 10;
        number = (number - number % 10) / 10;
        size--;

    }
    return array;
}

//печать массива
void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    while (i < count)
    {
        System.Console.Write(array[i]);
        i++;
    }
}

start:
Console.ForegroundColor = ConsoleColor.White;


int num = Prompt("Введите число : ");
int sizenum = SizeOfNumber(num);
int[] arrayNum = FillArray(num, sizenum);

//Ошибка, меньше 3 цифр
if (sizenum <= 2)
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"{num}-> Ошибка, третьей цифры нет");
    goto start;
}


//вывод третьей цифры заданного числа
else
{
    System.Console.Write($"{num}->");
    int result = num;

    while (sizenum > 3)
    {
        result = (result - (result % 10)) / 10;
        sizenum--;
    }
    result = result % 10;
    System.Console.WriteLine($"{result}");


    // вариант с массивом

    Console.ForegroundColor = ConsoleColor.Yellow;
    PrintArray(arrayNum);
    System.Console.WriteLine($"->{arrayNum[2]}");

}