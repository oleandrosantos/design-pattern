// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationPatterns;
using DesignPatterns.CreationPatterns.Builder;

Console.WriteLine("** Singleton ** ");
Singleton s1 = Singleton.GetInstance("Dado 1");
Singleton s2 = Singleton.GetInstance("Dado 1");

string ResultIsEquals = s1 == s2 ? "São iguais" : "São diferentes";
Console.WriteLine(ResultIsEquals);

var diretor = new ComputadorDiretor();
var builderPCGamer = new ComputadorGamerBuilder();
var builderPC = new ComputadorBuilder();
diretor.ComputadorBuilder = builderPCGamer;
diretor.MontandoPCGamer();
Console.WriteLine(diretor.GetComputador().ToString());
diretor.ComputadorBuilder = builderPC;
diretor.MontandoPCEscritorio();
Console.WriteLine(diretor.GetComputador().ToString());

