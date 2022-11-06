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
        ComputadorBuilder = new ComputadorGamerBuilder();
        _computadorBuilder.AdicionarPlacaMae("ASUS A123456-BR")
                            .AdicionarProcessador("Ryzen 7")
                            .AdicionarMemoriaRam("32 Gbs")
                            .AdicionarFonte("Corsair 800W")
                            .AdicionarDiscoRigido("520 SSD")
                            .AdicionarPlacaDeVideo("GTX 1080 TI")
                            .InstalarSistemaOperacional("Windows 11")
                            .AdicionarGabinete("Gabinete Gamer INOVA-X-GOLD");
    }
    public void MontandoPCEscritorio()
    {
        ComputadorBuilder = new ComputadorBuilder();
        _computadorBuilder.AdicionarPlacaMae("ASUS A123456-BR")
                            .AdicionarProcessador("Ryzen 3")
                            .AdicionarMemoriaRam("8 Gbs")
                            .AdicionarFonte("Corsair 350W")
                            .AdicionarDiscoRigido("240 SSD")
                            .InstalarSistemaOperacional("Ubuntu 22.10")
                            .AdicionarGabinete("Gabinete Escritorio");
    }

    public IComputadorBuilder GetComputador() => _computadorBuilder;

    public void Reset() => _computadorBuilder = null;
}