using System.Reflection.Metadata.Ecma335;

namespace DesignPatterns.CreationPatterns.Builder;

public class ComputadorDiretor
{
    private IComputadorBuilder _computadorBuilder;

    public IComputadorBuilder ComputadorBuilder
    {
        set { _computadorBuilder = value; }
    }

    public void MontandoPCGamer()
    {
        _computadorBuilder.AdicionarPlacaMae("ASUS A123456-BR");
        _computadorBuilder.AdicionarProcessador("Ryzen 7");
        _computadorBuilder.AdicionarMemoriaRam("32 Gbs");
        _computadorBuilder.AdicionarFonte("Corsair 800W");
        _computadorBuilder.AdicionarDiscoRigido("520 SSD");
        _computadorBuilder.AdicionarPlacaDeVideo("GTX 1080 TI");
        _computadorBuilder.InstalarSistemaOperacional("Windows 11");
        _computadorBuilder.AdicionarGabinete("Gabinete Gamer INOVA-X-GOLD");
    }
    public void MontandoPCEscritorio()
    {
        _computadorBuilder.AdicionarPlacaMae("ASUS A123456-BR");
        _computadorBuilder.AdicionarProcessador("Ryzen 3");
        _computadorBuilder.AdicionarMemoriaRam("8 Gbs");
        _computadorBuilder.AdicionarFonte("Corsair 350W");
        _computadorBuilder.AdicionarDiscoRigido("240 SSD");
        _computadorBuilder.InstalarSistemaOperacional("Ubuntu 22.10");
        _computadorBuilder.AdicionarGabinete("Gabinete Escritorio");
    }

    public IComputadorBuilder GetComputador() => _computadorBuilder;
}