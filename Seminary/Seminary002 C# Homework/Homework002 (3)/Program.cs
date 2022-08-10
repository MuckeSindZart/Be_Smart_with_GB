// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hello, World! Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
System.Console.WriteLine("PS. числа от от -2147483647 до 2147483647");

/*
Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/




int Prompt(string message)  //Ввод числа от -2147483648 до 2147483647
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}



int SizeOfNumber(int a)  //счетчик сколько цифр в числе для варианта № 1
{
    int size = 1;
    double i = 9;

    if (a < 0)
    { a = -a; }   //если - поменять знак на +

    while (a > i)       // если >= 99 size++
    {
        i = i * 10 + 9;
        size++;
    }

    return size;
}



int[] FillArray(int number, int size)   //заполнение массива начиная с конца, для варианта № 2
{
    int[] array = new int[size];
    while (size > 0)
    {
        size--;
        array[size] = number % 10;
        number = (number - number % 10) / 10;
    }
    return array;
}


void PrintArray(int[] array)   //печать массива в строку как будто это число, для варианта № 2
{

    int count = array.Length;
    int i = 1;
    System.Console.Write(array[0]);
    while (i < count)
    {
        if (array[0] < 0)
        {
            System.Console.Write(-array[i]);
        }
        else
        {
            System.Console.Write(array[i]);
        }
        i++;
    }
}

start: //возврат для ввода если ошибка
Console.ForegroundColor = ConsoleColor.White;


int num = Prompt("Введите число : ");

int sizenum = SizeOfNumber(num); //№1
int[] arrayNum = FillArray(num, sizenum);//№2
int result = num; //вывод резу


//Ошибка, меньше 3 цифр
if (sizenum <= 2)
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"{num}-> Ошибка, третьей цифры нет");

    goto start;
}



//вывод третьей цифры заданного числа, вариант № 1

while (sizenum > 3)
{
    result = (result - (result % 10)) / 10;
    sizenum--;
}
result = result % 10;
System.Console.WriteLine($"{num}->{result}");



// вариант с выводом массива как числа, вариант №2

Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(arrayNum);
System.Console.WriteLine($"->{arrayNum[2]}");



// вариант с преносом запятой и преобразованием в int, вариант №3

double doubleNum = num;

if (num < 0)
{
    while (doubleNum < -1000)
    {
        doubleNum = doubleNum * 0.1;

    }
}

else
{
    while (doubleNum > 1000)
    {
        doubleNum = doubleNum * 0.1;

    }
}
result = (int)doubleNum % 10;

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"{num}->{result}");

// Fix 
result = num;
while (result > 1000)
{
    result = result / 10;
}
result = result % 10;

Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine($"{num}->{result}");