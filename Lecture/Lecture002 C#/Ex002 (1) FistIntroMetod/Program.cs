// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Max of 9 numbers");


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
    }

int a1 = 12;
int a2 = 21;
int a3 = 39;
int b1 = 12;
int b2 = 23;
int b3 = 33;
int c1 = 13;
int c2 = 2;
int c3 = 33;

/*
int max = a1;
if (a2 > max) max = a2;
if (a3 > max) max = a3;

if (b1 > max) max = b1;
if (b2 > max) max = b2;
if (b3 > max) max = b3;

if (c1 > max) max = c1;
if (c2 > max) max = c2;
if (c3 > max) max = c3;

System.Console.WriteLine("max=" + max);
*/

//int max1 = Max(a1,a2,a3);
//int max2 = Max(b1,b2,b3);
//int max3 = Max(c1,c2,c3);

int max = Max(Max(a1,a2,a3),Max(b1,b2,b3),Max(c1,c2,c3));
Console.ForegroundColor = ConsoleColor.Yellow;
System.Console.WriteLine(max);


