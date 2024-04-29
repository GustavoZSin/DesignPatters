namespace StrategyInvestimento
{
    internal class RealizadorDeInvestimentos
    {
        public void Realiza(ContaBancaria contaBancaria, IInvestimento investimento)
        {
            double resultado = investimento.Calcula(contaBancaria);

            contaBancaria.Depositar(resultado);
            Console.WriteLine($"Novo saldo: R${contaBancaria.Saldo}");
        }
    }
}
