// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.
*/

/*
— Я думаю, — сказал князь, улыбаясь, — что,
ежели бы вас послали вместо нашего милого
Винценгероде, вы бы взяли приступом согласие
прусского короля. Вы так красноречивы. Вы
дадите мне чаю?
*/

string Txt = "— Я думаю, — сказал князь, улыбаясь, — что," +
             " ежели бы вас послали вместо нашего милого" +
             "\r\n Винценгероде, вы бы взяли приступом согласие" +
             " прусского короля. Вы так красноречивы. Вы" +
             " дадите мне чаю?";


// string = "qwety"
//           01234
// string[3] == e

string Replace(string text, char oldChar, char newChar)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldChar) { result = result + $"{newChar}"; }
        else { result = result + $"{text[i]}"; }
    }
    return result;
}

System.Console.WriteLine(Txt);
string newTXT = Replace(Txt, 'к', 'К');
System.Console.WriteLine(newTXT);
newTXT = Replace(newTXT, 'C', 'c');
System.Console.WriteLine(newTXT);
newTXT = Replace(newTXT, ' ', '|');
System.Console.WriteLine(newTXT);
newTXT = Replace(newTXT, 'а', 'А');
System.Console.WriteLine(newTXT);