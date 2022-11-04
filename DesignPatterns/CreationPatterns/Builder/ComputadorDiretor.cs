namespace DesignPatterns.CreationPatterns.Builder;

public class ComputadorDiretor
{
    private IComputadorBuilder _computadorBuilder;

    public IComputadorBuilder ComputadorBuilder
    {
        set { _computadorBuilder = value; }
    }

    public void MontanodoPCGamer()
    {
        
    }
    public void MontandoPCEscritorio(){}
}