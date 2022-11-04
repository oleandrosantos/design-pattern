namespace DesignPatterns.CreationPatterns.Builder;

public class ComputadorBuilder : IComputadorBuilder
{
    private Computador _computador = new Computador();
    
    public ComputadorBuilder()
    {
        _computador.ModeloComputador = "Computador de Escritorio";
    }

    public IComputadorBuilder AdicionarPlacaMae(string placaMae)
    {
        _computador.PlacaMae = placaMae;
        return this;
    }

    public IComputadorBuilder AdicionarProcessador(string processador)
    {
        _computador.Processador = processador;
        return this;
    }

    public IComputadorBuilder AdicionarMemoriaRam(string memoriaRam)
    {
        _computador.MemoriaRam = memoriaRam;
        return this;
    }

    public IComputadorBuilder AdicionarDiscoRigido(string discoRigido)
    {
        _computador.DiscoRigido = discoRigido;
        return this;
    }

    public IComputadorBuilder AdicionarFonte(string fonte)
    {
        _computador.Fonte = fonte;
        return this;
    }

    public IComputadorBuilder AdicionarGabinete(string gabinete)
    {
        _computador.Gabinete = gabinete;
        return this;
    }

    public IComputadorBuilder AdicionarPlacaDeVideo(string placaDeVideo)
    {
        _computador.PlacaDeVideo = placaDeVideo;
        return this;
    }

    public IComputadorBuilder InstalarSistemaOperacional(string sistema)
    {
        _computador.SistemaOperacional = sistema;
        return this;
    }
}

public class ComputadorGamerBuilder: IComputadorBuilder
{
    private Computador _computador = new Computador();

    public ComputadorGamerBuilder()
    {
        _computador.ModeloComputador = "PC GAMER X-TEL";
    }
    public IComputadorBuilder AdicionarPlacaMae(string placaMae)
    {
        _computador.PlacaMae = placaMae;
        return this;
    }

    public IComputadorBuilder AdicionarProcessador(string processador)
    {
        _computador.Processador = processador;
        return this;
    }

    public IComputadorBuilder AdicionarMemoriaRam(string memoriaRam)
    {
        _computador.MemoriaRam = memoriaRam;
        return this;
    }

    public IComputadorBuilder AdicionarDiscoRigido(string discoRigido)
    {
        _computador.DiscoRigido = discoRigido;
        return this;
    }

    public IComputadorBuilder AdicionarFonte(string fonte)
    {
        _computador.Fonte = fonte;
        return this;
    }

    public IComputadorBuilder AdicionarGabinete(string gabinete)
    {
        _computador.Gabinete = gabinete;
        return this;
    }

    public IComputadorBuilder AdicionarPlacaDeVideo(string placaDeVideo)
    {
        _computador.PlacaDeVideo = placaDeVideo;
        return this;
    }

    public IComputadorBuilder InstalarSistemaOperacional(string sistema)
    {
        _computador.SistemaOperacional = sistema;
        return this;
    }
}