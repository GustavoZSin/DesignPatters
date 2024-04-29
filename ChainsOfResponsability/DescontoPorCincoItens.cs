namespace ChainsOfResponsability
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            double desconto;
            if (orcamento.Itens.Count() > 5)
            {
                Console.WriteLine("Aplicado desconto por mais de 5 items...");
                return orcamento.Total * 0.1;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
