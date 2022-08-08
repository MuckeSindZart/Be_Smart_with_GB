// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Find Num in Array again");

void FillArray(int[] collection)
{
    int leng = collection.Length;
    int i = 0;
    while (i < leng)
    {
        collection[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int i = 0;
    int position = -1;

    while (i < count)
    {
        if (collection[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] array = new int[14];

FillArray(array);
PrintArray(array);
int find = Promt("Введите число ");
int pos = IndexOf(array, find);

if (pos != -1)
{
    System.Console.WriteLine("Искомое число " + find + " нашлось в массиве под индексом " + pos);
}
else
{
    System.Console.WriteLine("Искомого числа " + find + " в массиве нет ");
}
