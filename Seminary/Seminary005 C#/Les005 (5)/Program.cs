// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

*/
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

//зададим метод, приниамющий массив и возвращающий представление массива в виде строки
string StringifyArray(int[] array)
{
    string stringArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) stringArray += $"{array[i]} ";
        else stringArray += $"{array[i]}";
    }
    return stringArray;
}

//зададим метод, принимающий массив и возвращающий массив из произведений пар чисел
int[] MultiplyArray(int[] array)
{
    int l = array.Length;
    int[] newArray = new int[(l + 1)/2];

    for (int i = 0; i < l / 2; i++)
    {
        newArray[i] = array[i] * array[l - 1 - i];
    }

    if (l % 2 == 1) newArray[newArray.Length - 1] = array[l / 2];

    return newArray;
}


//зададим метод, принимающий массив и выводящий на консоль исходный массив и массив произведений пар чисел
void PrintResult(int[] array)
{
    int[] newArray = MultiplyArray(array);
    Console.WriteLine($"[{StringifyArray(array)}] -> {StringifyArray(newArray)}");
}

//вызовем 2 раза (для чётных и нечётных длин массивов)
//метод, создающий массив и выводящий на консоль исходный массив и массив произведений пар чисел
int[] array = CreateArray(4, 0, 10);
PrintResult(array);

int[] array2 = CreateArray(5, 0, 10);
PrintResult(array2);