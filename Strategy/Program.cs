using Strategy;

CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

Orcamento orcamento = new Orcamento(500.0);

IImposto icms = new ICMS();
IImposto iis = new IIS();
IImposto iccc = new ICCC();

Console.WriteLine(calculadora.Calcula(orcamento, icms));
Console.WriteLine(calculadora.Calcula(orcamento, iis));
Console.WriteLine(calculadora.Calcula(orcamento, iccc));

/*Neste cenário, a classe CalculadoraDeImpostos poderia ser removida e poderia ser chamado cada 
 * método "Calcula" de cada objeto que implementa IImposto. 
 * Ex: Console.WriteLine(icms.Calcula(orcamento));*/

/*Entretanto, caso fosse preciso que efetuar uma nova ação, como alterar o status do Orcamento ou 
 * notificar algum objeto, poderíamos utilizar essa classe para isso.*/