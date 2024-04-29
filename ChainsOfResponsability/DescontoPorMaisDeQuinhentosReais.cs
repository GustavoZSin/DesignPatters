namespace ChainsOfResponsability
{
    internal class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            double desconto;
            if (orcamento.Total > 500)
            {
                Console.WriteLine("Aplicado desconto por mais de R$500,00 ...");
                return orcamento.Total * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}