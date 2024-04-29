namespace ChainsOfResponsability
{
    internal class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            Console.WriteLine("Nenhum desconto aplicado...");
            return 0;
        }
    }
}