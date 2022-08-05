/*
4. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
*/

Console.Write("Введите Число : ");
string num = System.Console.ReadLine();
int input = int.Parse(num);

for (int i = -input; i<=input ;i++ )
{
    System.Console.Write(i+" ");
}
System.Console.WriteLine();