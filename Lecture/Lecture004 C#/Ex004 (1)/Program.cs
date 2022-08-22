// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Fun with Table Matrix");
System.Console.WriteLine();


string[,] table = new string[2, 5];
// String.Empty
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[2,2]  table[3,3]  table[4,4]
table[1, 2] = "туть";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.Write($" {table[rows, columns]} +");
    }
    System.Console.WriteLine();
} 

System.Console.WriteLine();

void PrintArray(int[,] matra)
{
for (int i = 0; i < matra.GetLength(0); i++)
    {
        for (int j = 0; j < matra.GetLength(1); j++)
        {
           System.Console.Write($"{matra[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matra)
{
    for (int i = 0; i < matra.GetLength(0); i++)
    {
        for (int j = 0; j < matra.GetLength(1); j++)
        {
            matra[i, j] = new Random().Next(1, 10); //[1; 10)
        }
    }
}

int[,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);
System.Console.WriteLine();
