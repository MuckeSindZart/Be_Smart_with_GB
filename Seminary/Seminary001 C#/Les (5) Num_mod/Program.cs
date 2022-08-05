/*
Напишите программу вычисления модуля числа.
	2 -> 2
	-3 -> 3
	-7 -> 7

*/

int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int inp = Promt("Введите число для вычесления модуля : ");
int num = inp;

if (inp == 0) {num = inp;}
if (inp < 0) {num =-inp;}
if (inp > 0) {num = inp;}

System.Console.WriteLine($"Модуль числа {inp} -> "+ num);
