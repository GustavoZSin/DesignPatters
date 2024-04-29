using ChainsOfResponsability;

Orcamento orcamento = new Orcamento();
orcamento.Adiciona(new Item("Batata", 100));
orcamento.Adiciona(new Item("Cenoura", 100));
orcamento.Adiciona(new Item("Microondas", 100));
orcamento.Adiciona(new Item("Caneta", 100));
orcamento.Adiciona(new Item("Lapis", 100));

CalculadoraDeDescontos calculadoraDeDescontos = new();
Console.WriteLine("Desconto: R$" + calculadoraDeDescontos.Calcula(orcamento));