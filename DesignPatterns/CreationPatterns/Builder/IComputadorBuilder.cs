namespace DesignPatterns.CreationPatterns.Builder;

public interface IComputadorBuilder
{
    IComputadorBuilder AdicionarPlacaMae(string placaMae);
    IComputadorBuilder AdicionarProcessador(string processador);
    IComputadorBuilder AdicionarMemoriaRam(string memoriaRam);
    IComputadorBuilder AdicionarDiscoRigido(string discoRigido);
    IComputadorBuilder AdicionarFonte(string fonte);
    IComputadorBuilder AdicionarGabinete(string gabinete);
    IComputadorBuilder AdicionarPlacaDeVideo(string placaDeVideo);
    IComputadorBuilder InstalarSistemaOperacional(string sistema);
}
