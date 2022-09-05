// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void PrintPascalsTriangle(int rows)
{
    int value = 1;
    for (int i = 0; i < rows; i++)
    {
         if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || i == 0) value = 1;
            else value = value * (i - j + 1) / j;
            System.Console.Write("|" +  value + "\t");
        }
        System.Console.WriteLine();
    }
}


PrintPascalsTriangle(20);