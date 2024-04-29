namespace ChainsOfResponsability
{
    public interface IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento);
    }
}
