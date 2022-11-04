
namespace DesignPatterns.CreationPatterns
{
    public class Singleton
    {
        private static Singleton _instance;

        //bloqueio responsavel por sincronizar as threads
        private static readonly object _instanceLock = new object();
        public string InformacaoImutavel { get; set; }
        private Singleton() { }

        public static Singleton GetInstance(string dadoImutavel)
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.InformacaoImutavel = dadoImutavel;
                    }
                }
            }

            return _instance;
        }
    }
}
