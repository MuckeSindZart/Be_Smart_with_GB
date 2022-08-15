// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Программа, которая принимает на вход количество элементов массива, заполняет его случайными значениями, а после ввыводит сортированный массив.");

/*задача для самых смелых, сортировка массива вставками.*/


int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int[] sortArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int j;
        int tmp = array[i];
        for (j = i - 1; j >= 0; j--)
        {
            if (array[j] < tmp)
                break;

            array[j + 1] = array[j];
        }
        array[j + 1] = tmp;
    }
    return array;
}


int[] arrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(0, 101);
        i++;
    }
    return array;
}


void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

//---------------------------//

int SetN = (Prompt("Введите число : "));
int[] result = arrayFill(SetN);
System.Console.WriteLine("New array");
printArray(result);
System.Console.WriteLine("Sort array");

printArray(sortArray(result));
