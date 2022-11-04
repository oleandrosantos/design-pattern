namespace DesignPatterns.CreationPatterns.Builder;

public interface IComputadorBuilder
{
  void AdicionarPlacaMae(string placaMae);
  void AdicionarProcessador(string processador);
  void AdicionarMemoriaRam(string memoriaRam);
  void AdicionarDiscoRigido(string discoRigido);
  void AdicionarFonte(string fonte);
  void AdicionarGabinete(string gabinete);
  void AdicionarPlacaDeVideo(string placaDeVideo);
  void InstalarSistemaOperacional(string sistema);
}
