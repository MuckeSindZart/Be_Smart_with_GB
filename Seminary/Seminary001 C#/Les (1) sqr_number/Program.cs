// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int value = Promt("Input Number : ");
int result = value * value;
System.Console.WriteLine($"result {value}^2 = " + result);