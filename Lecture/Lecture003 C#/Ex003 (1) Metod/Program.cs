// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! методы");


//Вид 1
void Metod1()
{
    System.Console.WriteLine("Метод 1");
    System.Console.WriteLine();
}

Metod1();


//Вид 2
void Metod2(string message)
{
    System.Console.WriteLine(message);
    System.Console.WriteLine();
}

void Metod21(string message, int count)
{
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine(message);
    }
    System.Console.WriteLine();
}

Metod2("Метод 2");
Metod21("Метод 2.1", 4);

//Вид 3

int Metod3()
{
    int today = 2022;
    return today;
}

int Year = Metod3();
System.Console.WriteLine("Метод 3 " + Year);
System.Console.WriteLine();


//Вид 4

string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
        if (i < count - 1) { result = result + ", "; }
    }
    result = result + ";";
    return result;
}

string strResult = Metod4(4, "Hi");
System.Console.WriteLine(strResult);
System.Console.WriteLine();


System.Console.WriteLine("Таблица умножения");

for (int i = 2; i <= 10; i++)
{
    
string strng = String.Empty; 
    for (int j = 1; j < 10; j++)
    { 
        strng = strng + $"{j}*{i}={i*j}\t";
        if (j == 9){System.Console.WriteLine(strng);}
    }
    
}