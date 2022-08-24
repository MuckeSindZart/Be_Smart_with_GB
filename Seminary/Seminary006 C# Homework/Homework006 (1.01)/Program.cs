// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

string TakeStringFromUser()
{
    string input = string.Empty;
    int count = 0;
    string stringArray = string.Empty;
    bool success = true;

    while (success)
    {

        input = UserInput("Введите следующее число : ");
        success = int.TryParse(input, out int result);

        if (success)
        {
            stringArray += result;
            count = AboveZeroCount(result, count);
            System.Console.WriteLine($"{stringArray} -> {count}");
        }
        else
        {
            break;
        }
        stringArray += ",";
    }

    System.Console.WriteLine("stop");
    return stringArray;
}




string UserInput(string message)
{
    System.Console.Write(message);
    string input = string.Empty;
    input = System.Console.ReadLine();

    return input;
}


int[] NumArrayFromString(string tmp) // преобразование строки в массив
{
    char[] separators = new char[] { ',', ' ' };
    string[] strArray = tmp.Split(separators, StringSplitOptions.RemoveEmptyEntries);

    int[] array = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        array[i] = int.Parse(strArray[i]);
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


void printArray(int[] array)
{
    if (array.Length == 0)
    {
        System.Console.Write($"[0] -> ");
        goto end;
    }
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]},");
    }
    System.Console.Write($"{array[array.Length - 1]}] -> ");
end:;
}

//-------------------------------------------------------------------------//


System.Console.WriteLine("Вводите целые числа (для выхода оставьте значение пустым или введите буквы) : ");

int[] newArray = NumArrayFromString(TakeStringFromUser());
int answer = AboveZeroInArray(newArray);

System.Console.WriteLine($"Итого: введено - {newArray.Length}, из них - {answer}, больше чем 0");

printArray(newArray);
System.Console.WriteLine(answer);