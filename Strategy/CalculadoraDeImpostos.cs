namespace Strategy
{
    internal class CalculadoraDeImpostos
    {
        public double Calcula(Orcamento orcamento, IImposto tipoDeImposto)
        {
            return tipoDeImposto.Calcula(orcamento);
        }
    }
}
