namespace DesignPatterns.CreationPatterns.Builder;

public class ComputadorBuilder : IComputadorBuilder
{
    private Computador _computador = new Computador();
    
    public ComputadorBuilder()
    {
        _computador.ModeloComputador = "Computador de Escriotorio";
    }
    
    public void AdicionarPlacaMae(string placaMae)
    {
        _computador.PlacaMae = placaMae;
    }

    public void AdicionarProcessador(string processador)
    {
        _computador.Processador = processador;
    }

    public void AdicionarMemoriaRam(string memoriaRam)
    {
        _computador.MemoriaRam = memoriaRam;
    }

    public void AdicionarDiscoRigido(string discoRigido)
    {
        _computador.DiscoRigido = discoRigido;
    }

    public void AdicionarFonte(string fonte)
    {
        _computador.Fonte = fonte;
    }

    public void AdicionarGabinete(string gabinete)
    {
        _computador.Gabinete = gabinete;
    }

    public void AdicionarPlacaDeVideo(string placaDeVideo)
    {
        _computador.PlacaDeVideo = placaDeVideo;
    }

    public void InstalarSistemaOperacional(string sistema)
    {
        _computador.SistemaOperacional = sistema;
    }
    public override string ToString()
    {
        return _computador.ToString();
    }
    public Computador GetComputador()
    {
        var computador = _computador;
        _computador = new Computador();
        return computador;
    }
}

public class ComputadorGamerBuilder: IComputadorBuilder
{
    private Computador _computador = new Computador();

    public ComputadorGamerBuilder()
    {
        _computador.ModeloComputador = "PC GAMER X-TEL";
    }
    public void AdicionarPlacaMae(string placaMae)
    {
        _computador.PlacaMae = placaMae;
    }

    public void AdicionarProcessador(string processador)
    {
        _computador.Processador = processador;
    }

    public void AdicionarMemoriaRam(string memoriaRam)
    {
        _computador.MemoriaRam = memoriaRam;
    }

    public void AdicionarDiscoRigido(string discoRigido)
    {
        _computador.DiscoRigido = discoRigido;
    }

    public void AdicionarFonte(string fonte)
    {
        _computador.Fonte = fonte;
    }

    public void AdicionarGabinete(string gabinete)
    {
        _computador.Gabinete = gabinete;
    }

    public void AdicionarPlacaDeVideo(string placaDeVideo)
    {
        _computador.PlacaDeVideo = placaDeVideo;
    }

    public void InstalarSistemaOperacional(string sistema)
    {
        _computador.SistemaOperacional = sistema;
    }

    public override string ToString()
    {
        return _computador.ToString();
    }

    public Computador GetComputador()
    {
        var computador = _computador;
        _computador = new Computador();
        return computador;
    }
}