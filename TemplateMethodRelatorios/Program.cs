using TemplateMethodRelatorios;

List<Conta> contas = new List<Conta>()
{
    new Conta("Gustavo", 500.00, "XYZ", "ABC-01X"),
    new Conta("Luana", 857.00, "UNI", "UNI-01Y"),
    new Conta("Jefti", 832.00, "AKT", "AKT-01Z"),
    new Conta("Clara", 389.00, "SBC", "SBC-01A")
};

RelatorioSimples relatorioSimples = new RelatorioSimples();
relatorioSimples.Imprime(contas);

Console.WriteLine();

RelatorioComplexo complexo = new RelatorioComplexo();
complexo.Imprime(contas);
