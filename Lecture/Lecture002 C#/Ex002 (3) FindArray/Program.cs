// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Find in Array");

int[] array = { 681, 26, 33, 14, 53, 62, 71, 18 };

int n = array.Length;

System.Console.WriteLine("Введите число : ");
string input = System.Console.ReadLine();
int find = int.Parse(input);

int findindex = 0;
int i = 0;

while (i < n)
{
    if (array[i] == find)
    {
        findindex = 1;
        System.Console.WriteLine("Число " + find + " находится в массиве под индексом - " + i + ".");
        break;
    }
    i++;
}

if (findindex == 0) { System.Console.WriteLine("В массиве такоt числj " + find + ", отсутствует."); }