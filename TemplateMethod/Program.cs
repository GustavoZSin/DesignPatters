using TemplateMethod;

CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

Orcamento orcamento = new Orcamento();

IImposto icms = new ICMS();
IImposto iis = new IIS();
IImposto iccc = new ICCC();

orcamento.Adiciona(new Item("Batata", 150.0));
orcamento.Adiciona(new Item("Cenoura", 100.0));
//orcamento.Adiciona(new Item("Batata", 100.0));

Console.WriteLine(calculadora.Calcula(orcamento, icms));
Console.WriteLine(calculadora.Calcula(orcamento, iis));
Console.WriteLine(calculadora.Calcula(orcamento, iccc));

IImposto icpp = new ICPP();
IImposto ikcv = new IKCV();
IImposto ihit = new IHIT();

Console.WriteLine(calculadora.Calcula(orcamento, icpp));
Console.WriteLine(calculadora.Calcula(orcamento, ikcv));
Console.WriteLine(calculadora.Calcula(orcamento, ihit));


/*Neste cenário, a classe CalculadoraDeImpostos poderia ser removida e poderia ser chamado cada 
 * método "Calcula" de cada objeto que implementa IImposto. 
 * Ex: Console.WriteLine(icms.Calcula(orcamento));*/

/*Entretanto, caso fosse preciso que efetuar uma nova ação, como alterar o status do Orcamento ou 
 * notificar algum objeto, poderíamos utilizar essa classe para isso.*/