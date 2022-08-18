// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B."
+ "\r\n3, 5 -> 243 (3⁵)\r\n2, 4 -> 16 (2⁴)");

/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 (2⁴)
*/

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

double Exponentiation(double A, int B)
{
    int count = B;
    int tmp = 1;
    if (B == 0) {  return 1; }
    else
    {

        if (B < 0) { count = -count; }

        for (int i = 1; i <= count; i++)
        {
            tmp = tmp * (int)A;
        }

        if (B < 0)
        { A = 1.0 / tmp; ; }
        
        else
        { A = tmp; }

        return A;
    }
}

void upIndexINTtoSTRING(int A, int B) // абсолютно необязательно, просто баловство (3, 5 to 3⁵)
{
    string txt = "⁰¹²³⁴⁵⁶⁷⁸⁹";
    string size = $"{B}";
    int[] numArray = new int[size.Length];
    string result = String.Empty;
    if (B < 0) { result = "⁻"; }
    for (int i = 0; i < size.Length; i++)
    {
        numArray[i] = size[i] - '0';                // ASCII magic ---> size[i] - '0' -> '9' - '0' =  57 -  48 = 9;

        for (int j = 0; j < txt.Length; j++)
        {
            if (numArray[i] == j) { result = result + $"{txt[j]}"; break; }
        }
    }

    result = $"({A}{result})";
    System.Console.WriteLine(result);
}


//------------------------------------------------------//


int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");
double result = Exponentiation(A, B);


System.Console.Write($"{A},{B} -> {result} ");
upIndexINTtoSTRING(A, B);
