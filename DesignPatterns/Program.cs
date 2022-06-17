// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationPatterns;

Console.WriteLine("** Singleton ** ");
Singleton s1 = Singleton.GetInstance("Dado 1");
Singleton s2 = Singleton.GetInstance("Dado 1");

string ResultIsEquals = s1 == s2 ? "São iguais" : "São diferentes";
Console.WriteLine(ResultIsEquals);