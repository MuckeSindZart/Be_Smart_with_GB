int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int c = new Random().Next(1,10);
int d = new Random().Next(1,10);
int e = new Random().Next(1,10);

int max=a, num=1 ;
    if (b>max)
{ 
    max = b; num=2;
    }
    if (c>max)
{ 
    max = c; num=3;
    }
    if (d>max)
{ 
    max = d; num=4;
    }
    if (e>max)
{
    max = e; num=5;
    }

Console.WriteLine("Самая большая гиря из 5 случайно выбраных.");
Console.WriteLine("Это гиря №" + num + ". Её вес равен - " + max);