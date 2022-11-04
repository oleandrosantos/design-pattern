// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationPatterns;
using DesignPatterns.CreationPatterns.Builder;

#region CriationPatterns
Console.WriteLine("** CREATIONS PATTERNS ** \n");

Console.WriteLine("** Singleton ** \n");
Singleton s1 = Singleton.GetInstance("Dado 1");
Singleton s2 = Singleton.GetInstance("Dado 1");

Console.WriteLine("s1 e s2 \n");
//verificando se as instancias singletons são igauis
string ResultIsEquals = s1 == s2 ? "s1 e s2 - São iguais\n" : "s1 e s2 - São diferentes\n";
Console.WriteLine(ResultIsEquals);

Console.WriteLine("** Builder ** \n");
//criando computador pre-configurados atravez de um diretor
var diretor = new ComputadorDiretor();
diretor.MontandoPCGamer();
Console.WriteLine(diretor.GetComputador().ToString());
diretor.MontandoPCEscritorio();
Console.WriteLine(diretor.GetComputador().ToString());

//Criando computador personalizado atravez do builder
var computador = ComputadorBuilder.getComputadorBuilder("Computador Personalizado")
    .AdicionarProcessador("FX 6300")
    .AdicionarPlacaMae("ASUS M5A3LX-BR3")
    .AdicionarDiscoRigido("120 GB")
    .AdicionarFonte("200W")
    .AdicionarMemoriaRam("16 GB");

Console.WriteLine(computador.ToString());

#endregion