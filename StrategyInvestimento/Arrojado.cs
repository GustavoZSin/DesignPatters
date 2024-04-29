using StrategyInvestimento;

internal class Arrojado : IInvestimento
{
    public double Calcula(ContaBancaria conta)
    {
        int chanceSucesso = new Random().Next(100);
        double resultado;

        if (chanceSucesso <= 20)
            resultado = conta.Saldo * 0.05;
        else if (chanceSucesso > 20 && chanceSucesso < 50)
            resultado = conta.Saldo * 0.03;
        else
            resultado = conta.Saldo * 0.006;

        return resultado;
    }
}