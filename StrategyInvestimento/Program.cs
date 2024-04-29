using StrategyInvestimento;

ContaBancaria maria = new ContaBancaria();
maria.Nome = "Maria";
maria.Depositar(300);

RealizadorDeInvestimentos realizadorDeInvestimentos = new();

IInvestimento conservador = new Conservador();
IInvestimento moderado = new Moderado();
IInvestimento arrojado = new Arrojado();

realizadorDeInvestimentos.Realiza(maria, conservador);
realizadorDeInvestimentos.Realiza(maria, moderado);
realizadorDeInvestimentos.Realiza(maria, arrojado);