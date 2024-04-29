namespace StrategyInvestimento
{
    public class ContaBancaria
    {
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}