namespace StrategyInvestimento
{
    internal class Conservador : IInvestimento
    {
        public double Calcula(ContaBancaria conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
