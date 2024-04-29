using StrategyInvestimento;

internal class Moderado : IInvestimento
{
    public double Calcula(ContaBancaria conta)
    {
        bool investimentoSucesso = new Random().Next(100) >= 50;
        double resultado;

        if (investimentoSucesso)
            resultado = conta.Saldo * 0.025;
        else
            resultado = conta.Saldo * 0.007;

        return resultado;
    }
}