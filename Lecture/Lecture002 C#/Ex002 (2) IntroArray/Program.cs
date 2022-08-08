// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Array first touch.");

int[] array = {1,2,3,4,5,6,7,8212,19};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
    }

int max = Max(Max(array[0],array[1],array[2]),
              Max(array[3],array[4],array[5]),
              Max(array[6],array[7],array[8]));




System.Console.WriteLine("max="+max);




