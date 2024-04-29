namespace ChainsOfResponsability
{
    internal class CalculadoraDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            /*Cada objeto de desconto possui uma propriedade que liga com o próximo da sequência.
              Para determinar qual será o próximo da corrente a ser executado, referencia-se
              conforme exemplo abaixo.*/
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}
