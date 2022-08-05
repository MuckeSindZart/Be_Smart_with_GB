// See https://aka.ms/new-console-template for more information
Console.Write("Input UserName : ");
string userName = Console.ReadLine();

if (userName=="Lupa" || userName=="lupa") 
{
  Console.WriteLine ("No! I am Lupa!");
    }  

if (userName=="Pupa" || userName=="pupa") 
{
    Console.WriteLine ("Oh! Hello, Pupa! It's me Lupa!");
    }

if (userName!="Lupa" && userName!="Pupa") 
    {
    Console.WriteLine ("Hi " + userName + "! Whear is Pupa?");
}