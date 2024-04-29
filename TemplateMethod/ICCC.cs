namespace TemplateMethod
{
    internal class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double total = 0;
            if (orcamento.Valor < 1000.00)
            {
                total = orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor >= 1000.00 && orcamento.Valor <= 3000.00)
            {
                total = orcamento.Valor * 0.07;
            }
            else if (orcamento.Valor > 3000.00)
            {
                total = orcamento.Valor * 0.08 + 30;
            }

            return total;
        }
    }
}
