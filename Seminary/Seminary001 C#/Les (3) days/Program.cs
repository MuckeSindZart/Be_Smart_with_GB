/*
2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
    3 -> Среда 
    5 -> Пятница
*/


System.Console.Write("Введите день недели : ");
string input = System.Console.ReadLine();
int day = int.Parse(input);

 if (day == 1) {System.Console.WriteLine("Сегодня понедельник");}
 if (day == 2) {System.Console.WriteLine("Сегодня вторник");}
 if (day == 3) {System.Console.WriteLine("Сегодня среда");}
 if (day == 4) {System.Console.WriteLine("Сегодня четверг");}
 if (day == 5) {System.Console.WriteLine("Сегодня пятница");}
 if (day == 6) {System.Console.WriteLine("Сегодня суббота");}
 if (day == 7) {System.Console.WriteLine("Сегодня воскресенье");}
 if (day > 7) {System.Console.WriteLine("Такого дня недели не бывает");}
 if (day <= 0) {System.Console.WriteLine("Такого дня недели не бывает");}